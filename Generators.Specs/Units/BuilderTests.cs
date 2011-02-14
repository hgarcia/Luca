using Luca.Generators;
using NUnit.Framework;
using SharpTestsEx;

namespace Generators.Specs.Units
{
    [TestFixture]
    public class BuilderTests
    {
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