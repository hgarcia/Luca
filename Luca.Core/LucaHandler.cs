using System;
using System.Text;
using System.Web;
using Jint;

namespace Luca.Core
{
    public class LucaHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var js = new JintEngine();
            var sb = new StringBuilder();
            js.SetParameter("response", sb);
            js.SetParameter("request", Console.In);

            var script = new ScriptContext().GetCurrentContext;
            script += @"var a = [1,2,3,4,5];
                response.Append(a.first());";
            js.Run(script);
            context.Response.Write(sb.ToString());
        }
    }
}
