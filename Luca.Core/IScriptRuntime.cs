using System.Text;

namespace Luca.Core
{
    public interface IScriptRuntime
    {
        dynamic Execute();
    }
}