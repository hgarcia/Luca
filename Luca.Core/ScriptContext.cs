using System.IO;
using System.Reflection;

namespace Luca.Core
{
    public class ScriptContext : IScriptContext
    {
        public ScriptContext()
        {
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
                        GetCurrentContext += new StreamReader(stream).ReadToEnd();
                }   
            }
        }

        public string GetCurrentContext{ get; private set;}
    }
}