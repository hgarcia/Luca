using System.Collections.Generic;
using Jint.Native;

namespace Jint.PrototypeExtension
{
    public class JsInstanceComparer : IEqualityComparer<JsInstance>
    {
        public bool Equals(JsInstance x, JsInstance y)
        {
            return x.GetType() == y.GetType() &&
                   x.Value.ToString() == y.Value.ToString();
        }

        public int GetHashCode(JsInstance obj)
        {
            return obj.GetHashCode();
        }
    }
}