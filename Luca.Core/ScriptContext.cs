using System.IO;
using System.Reflection;
using System.Text;

namespace Luca.Core
{
    public class ScriptContext : IScriptContext
    {
        public ScriptContext()
        {
            GetCurrentContext = new StringBuilder();
            loadCoreLibraries();
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