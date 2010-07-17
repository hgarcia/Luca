using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Jint;
using System.IO;
using System.Reflection;

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

            var script = File.ReadAllText(context.Server.MapPath("libs/prototype.js"));
            //var script = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("core_js_libs/prototype.js")).ReadToEnd();
            script += @"var a = [1,2,3,4,5];
                response.Append(a.first());";
            js.Run(script);
            context.Response.Write(sb.ToString());
        }
    }
}
