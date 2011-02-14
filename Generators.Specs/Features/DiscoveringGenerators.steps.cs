
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Luca.Generators;
using SharpTestsEx;

namespace Generators.Specs.Features 
{
    public partial class DiscoveringGenerators 
    {
        private Runner _runner;
        private StringBuilder _writer;
        private readonly IDictionary<string, Type> _generators = new Dictionary<string, Type>();

        private void When_passing_a_real_command()
        {
            _runner = new Runner(new[] { "create-app" }, new StringWriter(), _generators);
        }

        private void Then_should_create_the_proper_command_parser()
        {
            _runner.Parameters.Should().Be.InstanceOf<AppGeneratorParams>();
        }

        private void When_passing_a_non_existent_command()
        {
            _writer =  new StringBuilder();
            _runner = new Runner(new[] { "fake" }, new StringWriter(_writer), _generators);
        }

        private void Then_should_return_a_message()
        {
            _writer.ToString().ToLower().Should().Contain("unknown generator");
        }
    }
}
