using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Luca.Specs.SpecHelpers
{
    /// <summary>
    /// This class mocks objects for the Http protocol
    /// </summary>
    public class HttpMock
    {
        private readonly string _qs = string.Empty;
        private readonly HttpRequest _request;
        private const BindingFlags Flags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public HttpMock(string fileName, string urlWithoutQs) : this(fileName,urlWithoutQs,string.Empty)
        {
        }

        public HttpMock(string fileName, string urlWithoutQs, string qs)
        {
            _qs = qs;
            _request = new HttpRequest(fileName, string.Format("{0}?{1}", urlWithoutQs, qs), qs);
            Method = HttpVerb.GET;
            ServerVariables = new NameValueCollection
                                  {
                                      {"REMOTE_ADDR", "127.0.0.1"},
                                      {"HTTP_HOST", "127.0.0.1"},
                                      {"URL", urlWithoutQs},
                                      {"SERVER_NAME", "127.0.0.1"},
                                      {"LOCAL_ADDR", "127.0.0.1"},
                                      {"REMOTE_ADDR", "127.0.0.1"},
                                      {"REQUEST_METHOD", "GET"},
                                  };
        }
        public string[] AcceptTypes { get; set; }
        public HttpVerb Method { get; set; }
        public HttpResponse Response{ get; set; }
        public NameValueCollection Headers { get; set; }
        public NameValueCollection Forms { get; set; }
        public NameValueCollection ServerVariables { get; set; }
            
        public HttpContext GetContext()
        {
            var context = new HttpContext(_request, new HttpResponse(new StringWriter()));

            setForm(context);
            setServerVariables(context);
            setFields(context);

            return context;
        }

        private void setForm(HttpContext context)
        {
            if (Method.ToString().ToUpper() != "POST" || string.IsNullOrEmpty(_qs)) return;
            var form = context.Request.Form;
            form.GetType().GetMethod("MakeReadWrite", Flags).Invoke(form, null);
            _qs.Split('&')
                .Select(q => q.Split('='))
                .ToList()
                .ForEach(q =>
                             {
                                 if (q.Length == 2)
                                     context.Request.Form.Add(q[0], q[1]);
                             });
            form.GetType().GetMethod("MakeReadOnly", Flags).Invoke(form, null);
        }

        private void setServerVariables(HttpContext context)
        {
            var type = context.Request.ServerVariables.GetType();
            var methods = type.GetMethods(Flags);
            methods.First(m => m.Name == "MakeReadWrite").Invoke(context.Request.ServerVariables, null);
            foreach (string key in ServerVariables.Keys)
            {
                methods.First(m => m.Name == "AddStatic").Invoke(context.Request.ServerVariables, new[] { key, ServerVariables[key] });
            }
            methods.First(m => m.Name == "MakeReadOnly").Invoke(context.Request.ServerVariables, null);
        }

        private void setFields(HttpContext context)
        {
            var fields = context.Request.GetType().GetFields(Flags);
            fields.First(f => f.Name == "_httpMethod").SetValue(context.Request, Method.ToString());
            if (AcceptTypes != null) fields.First(f => f.Name == "_acceptTypes").SetValue(context.Request, AcceptTypes);
        }
    }
}