using System;
using System.IO;
using Machine.Specifications;
using Luca.Generators;

namespace Luca.Specs
{
    [Subject("Running the generator with no parameters")]
    public class ApplicationGeneratorSpecs
    {
        Establish context = () =>
                                        {
                                            _args = null;
                                        };
        Because of = () => Exception = Catch.Exception(() => new AppGeneratorParams(_args));

        It should_fail = () => Exception.ShouldBeOfType<ArgumentException>();
        It should_have_message =
          () => Exception.Message.ShouldEqual("Missing argument. Please use the --help argument to learn more.");
       

        static string[] _args;
        static Exception Exception { get; set; }
    }

    [Subject("Running the generator with a . in a non empty folder")]
    public class GenerateSqueletonOnExecutingFolder
    {
        Establish context = () =>
                                        {
                                            _args = new[]{"."};
                                            _generator = new AppGenerator(new AppGeneratorParams(_args));
                                        };

        Because of = () => Exception = Catch.Exception(()=>_generator.Generate());

        It should_fail = () => Exception.ShouldBeOfType<IOException>();

        It should_have_message =
            () => Exception.Message.ShouldEqual("The folder needs to be empty to create a Luca application.");
                                    
        static Exception Exception { get; set; }
        static string[] _args;
        static AppGenerator _generator;
    }
}