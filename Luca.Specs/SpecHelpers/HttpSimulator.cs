using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.SessionState;

namespace Luca.Specs.SpecHelpers
{
    public class HttpSimulator : IDisposable
    {
        private const string DefaultPhysicalAppPath = @"c:\InetPub\wwwRoot\";
        private readonly NameValueCollection _formVars = new NameValueCollection();
        private readonly NameValueCollection _headers = new NameValueCollection();
        private string _applicationPath = "/";
        private StringBuilder _builder;
        private string _physicalApplicationPath = DefaultPhysicalAppPath;
        private string _physicalPath = DefaultPhysicalAppPath;
        private Uri _referer;
        private TextWriter _responseWriter;

        public HttpSimulator() : this("/", DefaultPhysicalAppPath)
        {
        }

        public HttpSimulator(string applicationPath) : this(applicationPath, DefaultPhysicalAppPath)
        {
        }

        public HttpSimulator(string applicationPath, string physicalApplicationPath)
        {
            ApplicationPath = applicationPath;
            PhysicalApplicationPath = physicalApplicationPath;
        }

        public string Host { get; private set; }
        public string LocalPath { get; private set; }
        public int Port { get; private set; }
        public string Page { get; private set; }

        public string ApplicationPath
        {
            get { return _applicationPath; }
            set
            {
                _applicationPath = value ?? "/";
                _applicationPath = NormalizeSlashes(_applicationPath);
            }
        }

        public string PhysicalApplicationPath
        {
            get { return _physicalApplicationPath; }
            set
            {
                _physicalApplicationPath = value ?? DefaultPhysicalAppPath;
                _physicalApplicationPath = StripTrailingBackSlashes(_physicalApplicationPath) + @"\";
            }
        }

        public string PhysicalPath
        {
            get { return _physicalPath; }
        }

        public TextWriter ResponseWriter
        {
            get { return _responseWriter; }
            set { _responseWriter = value; }
        }

        public string ResponseText
        {
            get { return (_builder ?? new StringBuilder()).ToString(); }
        }

        public SimulatedHttpRequest WorkerRequest { get; private set; }

        public void Dispose()
        {
            HttpContext.Current = null;
        }

        public HttpSimulator SimulateGetRequest(Uri url)
        {
            return SimulateRequest(url, HttpVerb.GET);
        }

        public HttpSimulator SimulatePostRequest(Uri url, NameValueCollection formVariables)
        {
            return SimulateRequest(url, HttpVerb.POST, formVariables, null);
        }

        public HttpSimulator SimulatePostRequest(Uri url, NameValueCollection formVariables, NameValueCollection headers)
        {
            return SimulateRequest(url, HttpVerb.POST, formVariables, headers);
        }

        public HttpSimulator SimulateRequest(Uri url, HttpVerb httpVerb)
        {
            return SimulateRequest(url, httpVerb, null, null);
        }

        public HttpSimulator SimulateRequest(Uri url, HttpVerb httpVerb, NameValueCollection headers)
        {
            return SimulateRequest(url, httpVerb, null, headers);
        }

        protected virtual HttpSimulator SimulateRequest(Uri url, HttpVerb httpVerb, NameValueCollection formVariables,
                                                        NameValueCollection headers)
        {
            HttpContext.Current = null;

            ParseRequestUrl(url);

            if (_responseWriter == null)
            {
                _builder = new StringBuilder();
                _responseWriter = new StringWriter(_builder);
            }

            SetHttpRuntimeInternals();

            string query = ExtractQueryStringPart(url);

            if (formVariables != null)
                _formVars.Add(formVariables);

            if (_formVars.Count > 0)
                httpVerb = HttpVerb.POST; //Need to enforce this.

            if (headers != null)
                _headers.Add(headers);

            WorkerRequest = new SimulatedHttpRequest(ApplicationPath, PhysicalApplicationPath, PhysicalPath, Page, query,
                                                     _responseWriter, Host, Port, httpVerb.ToString());

            WorkerRequest.Form.Add(_formVars);
            WorkerRequest.Headers.Add(_headers);

            if (_referer != null)
                WorkerRequest.SetReferer(_referer);

            InitializeSession();

            InitializeApplication();

            Console.WriteLine("host: " + Host);
            Console.WriteLine("virtualDir: " + _applicationPath);
            Console.WriteLine("page: " + LocalPath);
            Console.WriteLine("pathPartAfterApplicationPart: " + Page);
            Console.WriteLine("appPhysicalDir: " + _physicalApplicationPath);
            if (HttpContext.Current != null)
            {
                Console.WriteLine("Request.Url.LocalPath: " + HttpContext.Current.Request.Url.LocalPath);
                Console.WriteLine("Request.Url.Host: " + HttpContext.Current.Request.Url.Host);
                Console.WriteLine("Request.FilePath: " + HttpContext.Current.Request.FilePath);
                Console.WriteLine("Request.Path: " + HttpContext.Current.Request.Path);
                Console.WriteLine("Request.RawUrl: " + HttpContext.Current.Request.RawUrl);
                Console.WriteLine("Request.Url: " + HttpContext.Current.Request.Url);
                Console.WriteLine("Request.Url.Port: " + HttpContext.Current.Request.Url.Port);
                Console.WriteLine("Request.ApplicationPath: " + HttpContext.Current.Request.ApplicationPath);
                Console.WriteLine("Request.PhysicalPath: " + HttpContext.Current.Request.PhysicalPath);
            }
            Console.WriteLine("HttpRuntime.AppDomainAppPath: " + HttpRuntime.AppDomainAppPath);
            Console.WriteLine("HttpRuntime.AppDomainAppVirtualPath: " + HttpRuntime.AppDomainAppVirtualPath);
            Console.WriteLine("HostingEnvironment.ApplicationPhysicalPath: " +
                              HostingEnvironment.ApplicationPhysicalPath);
            Console.WriteLine("HostingEnvironment.ApplicationVirtualPath: " + HostingEnvironment.ApplicationVirtualPath);

            return this;
        }

        private static void InitializeApplication()
        {
            Type appFactoryType =
                Type.GetType(
                    "System.Web.HttpApplicationFactory, System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            var appFactory = ReflectionHelper.GetStaticFieldValue<object>("_theApplicationFactory", appFactoryType);
            ReflectionHelper.SetPrivateInstanceFieldValue("_state", appFactory, HttpContext.Current.Application);
        }

        private void InitializeSession()
        {
            HttpContext.Current = new HttpContext(WorkerRequest);
            HttpContext.Current.Items.Clear();
            var session =
                (HttpSessionState)
                ReflectionHelper.Instantiate(typeof (HttpSessionState), new[] {typeof (IHttpSessionState)},
                                             new FakeHttpSessionState());

            HttpContext.Current.Items.Add("AspSession", session);
        }

        public HttpSimulator SetReferer(Uri referer)
        {
            if (WorkerRequest != null)
                WorkerRequest.SetReferer(referer);
            _referer = referer;
            return this;
        }

        public HttpSimulator SetFormVariable(string name, string value)
        {
            if (WorkerRequest != null)
                throw new InvalidOperationException("Cannot set form variables after calling Simulate().");

            _formVars.Add(name, value);

            return this;
        }

        public HttpSimulator SetHeader(string name, string value)
        {
            if (WorkerRequest != null)
                throw new InvalidOperationException("Cannot set headers after calling Simulate().");

            _headers.Add(name, value);

            return this;
        }

        private void ParseRequestUrl(Uri url)
        {
            if (url == null) return;
            Host = url.Host;
            Port = url.Port;
            LocalPath = url.LocalPath;
            Page = StripPrecedingSlashes(RightAfter(url.LocalPath, ApplicationPath));
            _physicalPath = Path.Combine(_physicalApplicationPath, Page.Replace("/", @"\"));
        }

        private static string RightAfter(string original, string search)
        {
            if (search.Length > original.Length || search.Length == 0)
                return original;

            int searchIndex = original.IndexOf(search, 0, StringComparison.InvariantCultureIgnoreCase);

            if (searchIndex < 0)
                return original;

            return original.Substring(original.IndexOf(search) + search.Length);
        }

        private static string ExtractQueryStringPart(Uri url)
        {
            string query = url.Query ?? string.Empty;
            if (query.StartsWith("?"))
                return query.Substring(1);
            return query;
        }

        private void SetHttpRuntimeInternals()
        {
            var runtime = ReflectionHelper.GetStaticFieldValue<HttpRuntime>("_theRuntime", typeof (HttpRuntime));

            ReflectionHelper.SetPrivateInstanceFieldValue("_appDomainAppPath", runtime, PhysicalApplicationPath);
            const string vpathTypeName =
                "System.Web.VirtualPath, System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
            object virtualPath = ReflectionHelper.Instantiate(vpathTypeName, new[] {typeof (string)},
                                                              new object[] {ApplicationPath});
            ReflectionHelper.SetPrivateInstanceFieldValue("_appDomainAppVPath", runtime, virtualPath);
            ReflectionHelper.SetPrivateInstanceFieldValue("_codegenDir", runtime, PhysicalApplicationPath);

            HostingEnvironment environment = GetHostingEnvironment();
            ReflectionHelper.SetPrivateInstanceFieldValue("_appPhysicalPath", environment, PhysicalApplicationPath);
            ReflectionHelper.SetPrivateInstanceFieldValue("_appVirtualPath", environment, virtualPath);
            ReflectionHelper.SetPrivateInstanceFieldValue("_configMapPath", environment, new ConfigMapPath(this));
        }

        protected static HostingEnvironment GetHostingEnvironment()
        {
            HostingEnvironment environment;
            try
            {
                environment = new HostingEnvironment();
            }
            catch (InvalidOperationException)
            {
                environment = ReflectionHelper.GetStaticFieldValue<HostingEnvironment>("_theHostingEnvironment",
                                                                                       typeof (HostingEnvironment));
            }
            return environment;
        }

        protected static string NormalizeSlashes(string s)
        {
            if (String.IsNullOrEmpty(s) || s == "/") return "/";

            s = s.Replace(@"\", "/");

            string normalized = Regex.Replace(s, "(/)/+", "$1");
            normalized = StripPrecedingSlashes(normalized);
            normalized = StripTrailingSlashes(normalized);
            return "/" + normalized;
        }

        protected static string StripPrecedingSlashes(string s)
        {
            return Regex.Replace(s, "^/*(.*)", "$1");
        }

        protected static string StripTrailingSlashes(string s)
        {
            return Regex.Replace(s, "(.*)/*$", "$1", RegexOptions.RightToLeft);
        }

        protected static string StripTrailingBackSlashes(string s)
        {
            if (String.IsNullOrEmpty(s)) return string.Empty;
            return Regex.Replace(s, @"(.*)\\*$", "$1", RegexOptions.RightToLeft);
        }

        internal class ConfigMapPath : IConfigMapPath
        {
            private readonly HttpSimulator _requestSimulation;

            public ConfigMapPath(HttpSimulator simulation)
            {
                _requestSimulation = simulation;
            }

            public string GetMachineConfigFilename()
            {
                throw new NotImplementedException();
            }

            public string GetRootWebConfigFilename()
            {
                throw new NotImplementedException();
            }

            public void GetPathConfigFilename(string siteId, string path, out string directory, out string baseName)
            {
                throw new NotImplementedException();
            }

            public void GetDefaultSiteNameAndID(out string siteName, out string siteId)
            {
                throw new NotImplementedException();
            }

            public void ResolveSiteArgument(string siteArgument, out string siteName, out string siteId)
            {
                throw new NotImplementedException();
            }

            public string MapPath(string siteId, string path)
            {
                string page = StripPrecedingSlashes(RightAfter(path, _requestSimulation.ApplicationPath));
                return Path.Combine(_requestSimulation.PhysicalApplicationPath, page.Replace("/", @"\"));
            }

            public string GetAppPathForPath(string siteId, string path)
            {
                return _requestSimulation.ApplicationPath;
            }
        }

        public class FakeHttpSessionState : NameObjectCollectionBase, IHttpSessionState
        {
            private readonly HttpStaticObjectsCollection _staticObjects = new HttpStaticObjectsCollection();

            public FakeHttpSessionState()
            {
                SyncRoot = new Object();
                SessionID = Guid.NewGuid().ToString();
                Timeout = 30;
                IsNewSession = true;
            }

            public void Abandon()
            {
                BaseClear();
            }

            public void Add(string name, object value)
            {
                BaseAdd(name, value);
            }

            public void Remove(string name)
            {
                BaseRemove(name);
            }

            public void RemoveAt(int index)
            {
                BaseRemoveAt(index);
            }

            public void Clear()
            {
                BaseClear();
            }

            public void RemoveAll()
            {
                BaseClear();
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            public string SessionID { get; private set; }

            public int Timeout { get; set; }

            public bool IsNewSession { get; private set; }

            public SessionStateMode Mode
            {
                get { return SessionStateMode.InProc; }
            }

            public bool IsCookieless
            {
                get { return false; }
            }

            public HttpCookieMode CookieMode
            {
                get { return HttpCookieMode.UseCookies; }
            }

            public int LCID { get; set; }
            public int CodePage { get; set; }

            public HttpStaticObjectsCollection StaticObjects
            {
                get { return _staticObjects; }
            }

            public object this[string name]
            {
                get { return BaseGet(name); }
                set { BaseSet(name, value); }
            }

            public object this[int index]
            {
                get { return BaseGet(index); }
                set { BaseSet(index, value); }
            }

            public object SyncRoot { get; private set; }

            public bool IsSynchronized
            {
                get { return true; }
            }

            bool IHttpSessionState.IsReadOnly
            {
                get { return true; }
            }
        }
    }
}