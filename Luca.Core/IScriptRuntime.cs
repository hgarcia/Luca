namespace Luca.Core
{
    public interface IScriptRuntime
    {
        ILucaResponse Execute(ILucaRequest lucaRequest);
    }
}