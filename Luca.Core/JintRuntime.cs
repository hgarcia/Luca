using System.Collections.Generic;
using Jint;
using Luca.Jint.PrototypeExtension;

namespace Luca.Core
{
    public class JintRuntime : IScriptRuntime
    {
        private readonly IScriptContext _scriptContext;
        private IList<IExtensionRegister> _extensions;
        
        public JintRuntime(IScriptContext scriptContext) 
        {
            addDefaultExtensions();            
            _scriptContext = scriptContext;   
        }

        private void addDefaultExtensions()
        {
            _extensions = new List<IExtensionRegister> { new Registration() };            
        }

        public void AddCustomExtensions(IEnumerable<IExtensionRegister> extensions)
        {
            if (extensions == null) return;
            foreach (var register in extensions)
            {
                _extensions.Add(register);
            }
        }

        public dynamic Execute(ILucaRequest lucaRequest)
        {
            var js = new JintEngine(_extensions);
            var script = _scriptContext.GetCurrentContext;
            return js.Run(script.ToString());
        }
    }
}