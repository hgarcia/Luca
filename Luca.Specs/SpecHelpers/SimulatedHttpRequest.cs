#region Disclaimer/Info

///////////////////////////////////////////////////////////////////////////////////////////////////
// Subtext WebLog
// 
// Subtext is an open source weblog system that is a fork of the .TEXT
// weblog system.
//
// For updated news and information please visit http://subtextproject.com/
// Subtext is hosted at SourceForge at http://sourceforge.net/projects/subtext
// The development mailing list is at subtext-devs@lists.sourceforge.net 
//
// This project is licensed under the BSD license.  See the License.txt file for more information.
///////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace Luca.Specs.SpecHelpers
{
    public class SimulatedHttpRequest : SimpleWorkerRequest
    {
        private readonly string _host;
        private readonly string _physicalFilePath;
        private readonly int _port;
        private readonly string _verb;
        private Uri _referer;

        /// <summary>
        /// Creates a new <see cref="SimulatedHttpRequest"/> instance.
        /// </summary>
        /// <param name="applicationPath">App virtual dir.</param>
        /// <param name="physicalAppPath">Physical Path to the app.</param>
        /// <param name="physicalFilePath">Physical Path to the file.</param>
        /// <param name="page">The Part of the URL after the application.</param>
        /// <param name="query">Query.</param>
        /// <param name="output">Output.</param>
        /// <param name="host">Host.</param>
        /// <param name="port">Port to request.</param>
        /// <param name="verb">The HTTP Verb to use.</param>
        public SimulatedHttpRequest(string applicationPath, string physicalAppPath, string physicalFilePath, string page,
                                    string query, TextWriter output, string host, int port, string verb)
            : base(applicationPath, physicalAppPath, page, query, output)
        {
            if (host == null)
                throw new ArgumentNullException("host", "Host cannot be null.");

            if (host.Length == 0)
                throw new ArgumentException("Host cannot be empty.", "host");

            if (applicationPath == null)
                throw new ArgumentNullException("applicationPath",
                                                "Can't create a request with a null application path. Try empty string.");

            _host = host;
            _verb = verb;
            _port = port;
            _physicalFilePath = physicalFilePath;
            Headers = new NameValueCollection();
            Form = new NameValueCollection();
        }

        public NameValueCollection Headers { get; private set; }
        public NameValueCollection Form { get; private set; }

        internal void SetReferer(Uri referer)
        {
            _referer = referer;
        }

        public override string GetHttpVerbName()
        {
            return _verb;
        }

        public override string GetServerName()
        {
            return _host;
        }

        public override int GetLocalPort()
        {
            return _port;
        }

        public override string[][] GetUnknownRequestHeaders()
        {
            if (Headers == null || Headers.Count == 0)
            {
                return null;
            }
            var headersArray = new string[Headers.Count][];
            for (int i = 0; i < Headers.Count; i++)
            {
                headersArray[i] = new string[2];
                headersArray[i][0] = Headers.Keys[i];
                headersArray[i][1] = Headers[i];
            }
            return headersArray;
        }

        public override string GetKnownRequestHeader(int index)
        {
            if (index == 0x24)
                return _referer == null ? string.Empty : _referer.ToString();

            if (index == 12 && _verb == "POST")
                return "application/x-www-form-urlencoded";

            return base.GetKnownRequestHeader(index);
        }

        public override string GetFilePathTranslated()
        {
            return _physicalFilePath;
        }

        public override byte[] GetPreloadedEntityBody()
        {
            var formText = Form.Keys.Cast<string>().Aggregate(string.Empty,
                                                                           (current, key) =>
                                                                           current +
                                                                           string.Format("{0}={1}&", key,
                                                                                         Form[key]));
            return Encoding.UTF8.GetBytes(formText);
        }

        public override bool IsEntireEntityBodyIsPreloaded()
        {
            return true;
        }
    }
}