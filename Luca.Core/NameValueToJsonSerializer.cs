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
            for (int i = 0; i < collection.Keys.Count; i++)
            {
                sb.AppendFormat("\"{0}\":\"{1}\"", collection.Keys[i].ToLower(), collection[i]);
                if (i < collection.Keys.Count - 1)
                {
                    sb.Append(",");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }
        public string ToString(NameValueCollection collection)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            for (int i = 0; i < collection.Keys.Count; i++)
            {
                sb.AppendFormat("\"{0}\":\"{1}\"", collection.Keys[i].ToLower(), collection[i]);
                if (i < collection.Keys.Count-1)
                {
                    sb.Append(",");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}