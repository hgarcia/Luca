using System.Reflection;

namespace Jint.PrototypeExtension
{
    public class Registration : ExtensionRegister{
        public Registration() : base(Assembly.GetExecutingAssembly())
        {
            
        }
    }
}
