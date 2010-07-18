using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Luca.Core
{
    public class NameValueToJsonSerializer
    {
        public string ToString(HttpCookieCollection collection)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            foreach (string key in collection.Keys)
            {
                sb.AppendFormat("\"{0}\":\"{1}\"", key.ToLower(), collection[key]);
            }
            sb.Append("}");
            return sb.ToString();
        }
        public string ToString(NameValueCollection collection)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            foreach (string key in collection.Keys)
            {
                sb.AppendFormat("\"{0}\":\"{1}\"", key.ToLower(), collection[key]); 
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}