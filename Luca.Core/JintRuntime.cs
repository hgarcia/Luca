using Jint;

namespace Luca.Core
{
    public class JintRuntime : IScriptRuntime
    {
        private readonly IScriptContext _scriptContext;

        public JintRuntime(IScriptContext scriptContext)
        {
            _scriptContext = scriptContext;
        }

        public ILucaResponse Execute(ILucaRequest lucaRequest)
        {
            var js = new JintEngine();
            var lucaResponse = new LucaResponse();
            js.SetParameter("response", lucaResponse);

            var script = _scriptContext.GetCurrentContext;
            script.Append(@"var a = [1,2,3,4,5];
                response.Write(a.first());");
            js.Run(script.ToString());
            return lucaResponse;
        }
    }
}