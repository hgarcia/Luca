using System.Reflection;
using Jint;

namespace Luca.Jint.PrototypeExtension
{
    public class Registration : ExtensionRegister{
        public Registration() : base(Assembly.GetExecutingAssembly())
        {
            
        }
    }
}
