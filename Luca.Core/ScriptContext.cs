using System.IO;
using System.Reflection;
using System.Text;

namespace Luca.Core
{
    public class ScriptContext : IScriptContext
    {
        private readonly ILucaRequest _lucaRequest;

        public ScriptContext(ILucaRequest lucaRequest)
        {
            _lucaRequest = lucaRequest;
            GetCurrentContext = new StringBuilder();
            loadCoreLibraries();
            loadApplication();
        }

        private void loadApplication()
        {
            GetCurrentContext.AppendLine(@"var app = GetApplication(" + _lucaRequest.ToJson() + ");");
        }

        private void loadCoreLibraries()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var resources = currentAssembly.GetManifestResourceNames();
            foreach (var resource in resources)
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    if(stream!= null)
                        GetCurrentContext.AppendLine(new StreamReader(stream).ReadToEnd());
                }   
            }
        }

        public StringBuilder GetCurrentContext{ get; private set;}
    }
}