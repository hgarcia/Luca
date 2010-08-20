using System.Collections.Generic;

namespace Luca.Core.Encoders
{
    public class HeaderComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToLowerInvariant() == y.ToLowerInvariant();
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}