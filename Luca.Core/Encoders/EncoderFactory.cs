namespace Luca.Core.Encoders
{
    public class EncoderFactory
    {
        public IEncoder GetEncoderForContentType(string acceptHeaders)
        {
            if (acceptHeaders.Contains("application/json")) return new Json();

            if (acceptHeaders.Contains("plain/txt")) return new PlainText();

            return new Html();
        }
    }
}