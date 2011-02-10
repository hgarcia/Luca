using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Machine.Specifications;
using Luca.Generators;

namespace Luca.Specs.Generators
{
    [Subject("Running the generator with the --help parameter")]
    public class HelpParameter
    {
        Establish context = () => { 
            _args = new[] {"--help"};
            _runner = new Runner(_args, output, new Dictionary<string, Type>{{"application", typeof(AppGenerator)}});
        };

        private It should_display_the_help = () => builder.ToString().ShouldContain("usage");

        static string[] _args;
        static Runner _runner;
        static StringBuilder builder = new StringBuilder();
        static TextWriter output = new StringWriter(builder);
    }

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

        Because of = () => _generator.Generate(output);

        It should_fail_with_message = () => builder.ToString()
            .ShouldContain("The folder needs to be empty to create a Luca application.");

        private static StringBuilder builder = new StringBuilder(); 
        private static TextWriter output = new StringWriter(builder);
        static string[] _args;
        static AppGenerator _generator;
    }
}