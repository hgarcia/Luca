using System.IO;

namespace Luca.Generators
{
    public interface IGenerator
    {
        void Help(TextWriter output);
        void Generate(TextWriter output);
    }
}