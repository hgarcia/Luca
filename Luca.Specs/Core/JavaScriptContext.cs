using Machine.Specifications;
using Luca.Core;

namespace Luca.Specs.Core
{
    [Subject("Should load core libraries from embedded resources")]
    public class ScriptContextLoadsCore
    {
        private Establish context = () => { _context = new ScriptContext(); };
        private Because loads_core_libraries = () => { };
        private It should_containes_prototype = () => _context.GetCurrentContext.ToString().ShouldContain("prototype");
        private static IScriptContext _context;
    }

    [Subject("Jint Runtime should return a response after runing")]
    public class JintRuntimeResponse
    {
        private Establish context = () => { _context = new JintRuntime(new ScriptContext()); };
        private Because is_run = () => _response = _context.Execute(lucaRequest);
        private It should_return_a_LucaResponse = () => _response.ShouldBe(typeof (LucaResponse));
        private static IScriptRuntime _context;
        private static ILucaResponse _response;
        private static ILucaRequest lucaRequest;
    }
}
