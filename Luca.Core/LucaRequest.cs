using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Luca.Core
{
    public interface ILucaRequest
    {
        string ToJson();
    }

    public class LucaRequest : ILucaRequest
    {
        private readonly NameValueToJsonSerializer _jsonSerializer;

        public LucaRequest(HttpRequest request, NameValueToJsonSerializer jsonSerializer) : 
            this(request.Form, request.QueryString, request.Cookies, request.Headers,
                                              request.ServerVariables, request.Url, request.HttpMethod, jsonSerializer )
        {}

        private readonly NameValueCollection _form;
        private readonly NameValueCollection _qs;
        private readonly HttpCookieCollection _cookies;
        private readonly NameValueCollection _headers;
        private readonly NameValueCollection _serverVariables;
        private readonly Uri _url;
        private readonly string _httpMethod;

        public LucaRequest(NameValueCollection form, 
            NameValueCollection qs,
            HttpCookieCollection cookies, 
            NameValueCollection headers,
            NameValueCollection serverVariables,
            Uri url,
            string httpMethod,
            NameValueToJsonSerializer jsonSerializer)
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