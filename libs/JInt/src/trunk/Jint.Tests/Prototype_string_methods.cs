using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jint.Tests
{
    [TestClass]
    public class Prototype_string_methods
    {
        public IList<IExtensionRegister> prototype = new List<IExtensionRegister> { new PrototypeExtension.Registration() };
        
        [TestMethod]
        public void should_support_empty()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return [' '.empty(),''.empty()];");
            Assert.IsFalse(result[0]);
            Assert.IsTrue(result[1]);
        }
        [TestMethod]
        public void should_support_capitalize()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return 'HELLO WOrlD!'.capitalize();");
            Assert.AreEqual("Hello world!",result);
        }
        [TestMethod]
        public void should_support_blank()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return ''.blank();");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void if_string_contain_only_spaces_blank_is_true()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return '     '.blank();");
            Assert.IsTrue(result);           
        }

        [TestMethod]
        public void if_string_contains_characters_blank_is_false()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return '  klk  '.blank();");
            Assert.IsFalse(result);           
        }
    }
}
