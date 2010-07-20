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

            var script = new ScriptContext().GetCurrentContext;
            var request = new LucaRequest(context.Request, new NameValueToJsonSerializer());
            script += @"var app =  new Application(response," + request.ToJson() + ");";
            script += @"app.Get(""*"", function(req,res){ req.Append(""hello cruel world""); } );\n";
            script += @"app.Run();";
            js.Run(script);
            context.Response.Write(sb.ToString());
        }
    }
}
