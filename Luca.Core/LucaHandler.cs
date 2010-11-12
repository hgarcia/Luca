using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Luca.Core
{
    public class LucaHandler : IHttpHandler
    {
        private LucaRequest _request;
        private HttpContext _context;
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            _context = context;
            _request = new LucaRequest(context.Request, new NameValueToJsonSerializer());
            var scriptContext = new ScriptContext(_request);
            var controllerPath = GetAppRoot() + "controllers";
            //var viewPath = context.Server.MapPath("views") ?? "views";
            loadJsFiles(scriptContext, controllerPath);
            try
            {
                var js = new JintRuntime(scriptContext);
                dynamic response = js.Execute();
                encode(response, context);
            }catch(Exception e)
            {
                _context.Response.Write(scriptContext.GetCurrentContext.ToString());
                _context.Response.Write(e.Message );
                _context.Response.Write(e.StackTrace);
            }
        }

        private string GetAppRoot()
        {
            try
            {
                return _context.Request.PhysicalApplicationPath;
            }catch
            {
                return string.Empty;
            }
        }

        private void encode(dynamic response, HttpContext context)
        {
            var accept = context.Request.Headers["Accept"] ?? "text/plain";
            var enconder = new Encoders.EncoderFactory()
                .GetEncoderForContentType(accept);

            var encodedResponse = enconder.Encode(response);
            context.Response.ContentType = enconder.ContentType;
            context.Response.Write(encodedResponse);
            return;
        }

        private void loadJsFiles(IScriptContext scriptContext, string pathToFiles)
        {
            Directory.GetFiles(pathToFiles).ToList()
                .ForEach(file =>
                             {
                                 scriptContext.GetCurrentContext.AppendLine(
                                     new StreamReader(file,Encoding.ASCII).ReadToEnd()
                                     );
                             }
                );
        }
    }
}
