using Jint.Native;
using Luca.Jint.PrototypeExtension;
using NUnit.Framework;
using SharpTestsEx;

namespace Luca.Jint.Specs
{
    [TestFixture]
    public class ExtensionPoints
    {
        [Test]
        public void test_extension_manager()
        {
            var registration = new Registration();

            registration.Extensions.Count.Should().Be.GreaterThan(0);
            registration.Extensions[typeof(JsArray)].Should().Not.Be.Null();
        }

    }
}
