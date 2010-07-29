﻿using Machine.Specifications;
using Luca.Core;

namespace Luca.Specs.Core
{
    [Subject("Should load core libraries from embedded resources")]
    public class ScriptContextLoadsCore
    {
        private Establish context = () => { _context = new ScriptContext(); };
        private Because loads_core_libraries = () => { };
        private It should_containes_prototype = () => _context.GetCurrentContext.ToString().ShouldContain("function GetApplication");
        private static IScriptContext _context;
    }

    [Subject("Jint Runtime should return a response after runing")]
    public class JintRuntimeResponse
    {
        private Establish context = () =>
                                        {
                                            var scriptContext = new ScriptContext();
                                            scriptContext.GetCurrentContext.Append("return 'hello world!';");
                                            _context = new JintRuntime(scriptContext);
                                        };
        private Because is_run = () => _response = _context.Execute(lucaRequest);
        private It should_return_a_string = () => ((string)_response).ShouldEqual("hello world!");
        private static IScriptRuntime _context;
        private static dynamic _response;
        private static ILucaRequest lucaRequest;
    }
}
