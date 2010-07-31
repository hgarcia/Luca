using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Luca.Core
{
    public class LucaRequest : ILucaRequest
    {
        private NameValueToJsonSerializer _jsonSerializer = new NameValueToJsonSerializer();
        private NameValueCollection _form = new NameValueCollection();
        private NameValueCollection _qs = new NameValueCollection();
        private HttpCookieCollection _cookies = new HttpCookieCollection();
        private NameValueCollection _headers = new NameValueCollection();
        private NameValueCollection _serverVariables = new NameValueCollection();
        private Uri _url = new Uri("http://localhost");
        private string _httpMethod = "GET";

        public LucaRequest()
        {
        }

        public LucaRequest(HttpRequest request, NameValueToJsonSerializer jsonSerializer)  
        {
            if (request == null) throw new ArgumentNullException("request", "The request can't be null");
            if (jsonSerializer == null)
                throw new ArgumentNullException("jsonSerializer", "The serializer can't be null");
            initialize(request.Form, request.QueryString, request.Cookies, request.Headers,
                                              request.ServerVariables, request.Url, request.HttpMethod, jsonSerializer);
        }

        public LucaRequest(NameValueCollection form, 
            NameValueCollection qs,
            HttpCookieCollection cookies, 
            NameValueCollection headers,
            NameValueCollection serverVariables,
            Uri url,
            string httpMethod,
            NameValueToJsonSerializer jsonSerializer)
        {
            initialize(form, qs, cookies, headers, serverVariables, url, httpMethod, jsonSerializer);
        }

        private void initialize(NameValueCollection form, NameValueCollection qs, HttpCookieCollection cookies, NameValueCollection headers, NameValueCollection serverVariables, Uri url, string httpMethod, NameValueToJsonSerializer jsonSerializer)
        {
            _form = form;
            _qs = qs;
            _cookies = cookies;
            _headers = headers;
            _serverVariables = serverVariables;
            _url = url;
            _httpMethod = httpMethod;
            _jsonSerializer = jsonSerializer;
        }

        public string ToJson()
        {
            var sb = new StringBuilder();
            sb.Append("{");
            sb.AppendFormat("\"path\":\"{0}\",", _url.AbsolutePath);
            sb.AppendFormat("\"method\":\"{0}\",", _httpMethod);
            sb.AppendFormat("\"form\":{0},", _jsonSerializer.ToString(_form));
            sb.AppendFormat("\"query\":{0},", _jsonSerializer.ToString(_qs));
            sb.AppendFormat("\"headers\":{0},", _jsonSerializer.ToString(_headers));
            sb.AppendFormat("\"serverVars\":{0},", _jsonSerializer.ToString(_serverVariables));
            sb.AppendFormat("\"cookies\":{0}", _jsonSerializer.ToString(_cookies));
            sb.Append("}");
            return sb.ToString();            
        }
    }
}