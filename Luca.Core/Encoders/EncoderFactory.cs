using System.Collections.Generic;
using System.Linq;

namespace Luca.Core.Encoders
{
    public class EncoderFactory
    {
        public IEncoder GetEncoderForContentType(IEnumerable<string> acceptHeaders)
        {
            if (acceptHeaders.Contains("application/json", new HeaderComparer()))
                return new Json();

            if (acceptHeaders.Contains("plain/txt", new HeaderComparer()))
                return new PlainText();

            return new Html();
        }
    }
}