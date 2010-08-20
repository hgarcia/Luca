namespace Luca.Core.Encoders
{
    public class PlainText : IEncoder
    {
        public string Encode(object toSerialize)
        {
            return toSerialize.ToString();
        }
    }
}
