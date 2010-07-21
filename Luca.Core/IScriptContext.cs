using System.Text;

namespace Luca.Core
{
    public interface IScriptContext
    {
        StringBuilder GetCurrentContext { get; }
    }
}