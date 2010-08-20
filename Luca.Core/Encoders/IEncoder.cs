namespace Luca.Core.Encoders
{
    public interface IEncoder
    {
        string SerializeObject(object toSerialize);
    }
}