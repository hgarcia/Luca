using System.IO;
using System.Linq;
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
            script.AppendLine(@"var app =  GetApplication(" + request.ToJson() + ", response);");
            var controllerPath = context.Server.MapPath("controllers") ?? "controllers";

            loadControllers(script, controllerPath);
            
            //script.AppendLine(@"app.Get(""movie/\d*"", function(req,res){ res.Append(""hello cruel world""); res.Append(req.query.id); } );");
            script.AppendLine(@"app.Run();");
            js.Run(script.ToString());

            context.Response.Write(sb.ToString());
        }

        private void loadControllers(StringBuilder script,string controllers)
        {
            Directory.GetFiles(controllers).ToList()
                .ForEach( file => script.AppendLine(
                    new StreamReader(file).ReadToEnd()
                    ) 
                );
        }
    }
}
