using System.Reflection;
using Jint.Native;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jint.Tests
{
    [TestClass]
    public class ExtensionPoints
    {
        [TestMethod]
        public void test_extension_manager()
        {
            var registration = new PrototypeExtension.Registration();
            Assert.IsTrue(registration.Extensions.Count > 0);
            Assert.IsNotNull(registration.Extensions[typeof(JsArray)]);
        }

    }
}
