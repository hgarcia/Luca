using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Luca.Core
{
    public interface ILucaRequest
    {
        string ToJson(NameValueToJsonSerializer jsonSerializer);
    }

    public class LucaRequest : ILucaRequest
    {
        public LucaRequest(HttpRequest request) : 
            this(request.Form, request.QueryString, request.Cookies, request.Headers,
                                              request.ServerVariables){ }
        private readonly NameValueCollection _form;
        private readonly NameValueCollection _qs;
        private readonly HttpCookieCollection _cookies;
        private readonly NameValueCollection _headers;
        private readonly NameValueCollection _serverVariables;

        public LucaRequest(NameValueCollection form, 
            NameValueCollection qs,
            HttpCookieCollection cookies, 
            NameValueCollection headers,
            NameValueCollection serverVariables)
        {
            _form = form;
            _qs = qs;
            _cookies = cookies;
            _headers = headers;
            _serverVariables = serverVariables;
        }

        public string ToJson(NameValueToJsonSerializer jsonSerializer)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            sb.AppendFormat("\"form\":{0},", jsonSerializer.ToString(_form));
            sb.AppendFormat("\"query\":{0},", jsonSerializer.ToString(_qs));
            sb.AppendFormat("\"headers\":{0},", jsonSerializer.ToString(_headers));
            sb.AppendFormat("\"serverVars\":{0},", jsonSerializer.ToString(_serverVariables));
            sb.AppendFormat("\"cookies\":{0}", jsonSerializer.ToString(_cookies));
            sb.Append("}");
            return sb.ToString();
        }
    }
}