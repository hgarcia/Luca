using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jint
{
    public class ExtensionRegister : IExtensionRegister
    {
        private readonly IDictionary<Type, IExtension> _extensions;

        protected ExtensionRegister()
        {
            _extensions = new Dictionary<Type, IExtension>();
            registerExtensions();
        }

        private void registerExtensions()
        {
            var asm = Assembly.GetExecutingAssembly();
            var types = asm.GetTypes()
                .Where(t => t.Namespace == GetType().Namespace && 
                    t.GetInterface("IExtension") != null);

            foreach (var extension in types.Select(Activator.CreateInstance).OfType<IExtension>())
            {
                _extensions.Add(extension.TypeName, extension);
            }
        }

        public IDictionary<Type, IExtension> Extensions
        {
            get { return _extensions; }
        }
    }
}
