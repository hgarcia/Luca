using System;

namespace Luca.Core.Encoders
{
    public class PlainText : IEncoder
    {
        public string Encode(object toSerialize)
        {
            return toSerialize.ToString();
        }

        public string ContentType
        {
            get { return "text/plain"; }
        }
    }
}
