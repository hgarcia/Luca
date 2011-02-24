using Luca.Generators;
using NUnit.Framework;
using SharpTestsEx;

namespace Generators.Specs.Units
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void when_second_argument_is_help_or_h_help_should_be_true()
        {
            var nullParams = new NullParams(new string[] { "create-app", "--help" });
            nullParams.Help.Should().Be.True();
            var createAppParams = new CreateAppParams(new string[] { "create-app", "-h" });
            createAppParams.Help.Should().Be.True();
        }

        [Test]
        public void when_second_argument_is_not_help_nor_h_help_should_be_false()
        {
            var createAppParams = new CreateAppParams(new string[] { "create-app", "h" });
            createAppParams.Help.Should().Be.False();
        }

        [Test]
        public void first_argument_should_be_use_as_the_generator_name()
        {
            var nullParams = new NullParams(new string[] {"create-app", "my-app"});
            nullParams.Generator.Should().Be.EqualTo("create-app");
        }

        [Test]
        public void when_passing_arguments_should_create_the_proper_param()
        {
            var createAppParams = Builder.CreateParams(new[]{"create-app","my_app"});
            createAppParams.Should().Be.OfType<CreateAppParams>();
            var modelParams = Builder.CreateParams(new[] {"model", "user"});
            modelParams.Should().Be.OfType<ModelParams>();
        }

        [Test]
        [ExpectedException(typeof(MissingGeneratorException))]
        public void when_passing_null_args_should_throw_exception()
        {
            Builder.CreateParams(null);
        }

        [Test]
        [ExpectedException(typeof(MissingGeneratorException))]
        public void when_passing_empty_args_should_throw_exception()
        {
            Builder.CreateParams(new string[]{});
        }

        [Test]
        public void when_passing_one_arg_should_return_a_nullparams()
        {
            var createAppParams = Builder.CreateParams(new[] { "create-app" });
            createAppParams.Should().Be.OfType<NullParams>();
        }
    }
}