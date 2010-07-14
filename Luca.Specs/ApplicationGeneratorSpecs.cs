using System;
using System.IO;
using Machine.Specifications;

namespace Luca.Specs
{
    [Subject("Running the generator with no parameters")]
    public class ApplicationGeneratorSpecs
    {
        private Establish context = () =>
                                        {
                                            _args = null;
                                        };
        Because of = () => Exception = Catch.Exception(() => new AppGeneratorParams(_args));

        It should_fail = () => Exception.ShouldBeOfType<ArgumentNullException>();

        private static string[] _args;
        private static Exception Exception { get; set; }
    }

    [Subject("Running the generator with a . in a non empty folder")]
    public class GenerateSqueletonOnExecutingFolder
    {
        private Establish context = () =>
                                        {
                                            _args = new[]{"."};
                                            _generator = new AppGenerator(new AppGeneratorParams(_args));
                                        };

        private Because of = () => Exception = Catch.Exception(()=>_generator.Generate());

        private It should_fail = () => Exception.ShouldBeOfType<IOException>();
                                    
        private static Exception Exception { get; set; }
        private static string[] _args;
        private static AppGenerator _generator;
    }
}