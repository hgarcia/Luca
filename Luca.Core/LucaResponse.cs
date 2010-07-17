using System.Text;

namespace Luca.Core
{
    public interface ILucaResponse
    {
        void Write(object value);
    }

    public class LucaResponse : ILucaResponse
    {
        private StringBuilder _sb;

        public LucaResponse()
        {
            _sb = new StringBuilder();
        }

        public void Write(object value)
        {
            _sb.Append(value);
        }
    }
}