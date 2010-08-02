using System.Collections.Generic;
using Jint;
using Luca.Jint.PrototypeExtension;
using NUnit.Framework;

namespace Luca.Jint.Specs
{
    [TestFixture]
    public class Prototype_string_methods
    {
        public IList<IExtensionRegister> prototype = new List<IExtensionRegister> { new Registration() };
        
        [Test]
        public void should_return_an_object()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return {
        request: 'hello',
        gets: [],
        posts: [],
        puts: [],
        deletes: []};");
            Assert.IsNotNull(result);    
        }

        [Test]
        public void should_suppot_endsWith()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return ['corporate'.endsWith('fun'),'open source'.endsWith('rce'),'numbers'.endsWith(5),'no-params'.endsWith()];");
            Assert.IsFalse(result[0]);
            Assert.IsTrue(result[1]);
            Assert.IsFalse(result[2]);
            Assert.IsFalse(result[3]);
        }
        
        [Test]
        public void should_support_empty()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return [' '.empty(),''.empty()];");
            Assert.IsFalse(result[0]);
            Assert.IsTrue(result[1]);
        }
        [Test]
        public void should_support_capitalize()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return 'HELLO WOrlD!'.capitalize();");
            Assert.AreEqual("Hello world!",result);
        }
        [Test]
        public void should_support_blank()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return ''.blank();");
            Assert.IsTrue(result);
        }

        [Test]
        public void if_string_contain_only_spaces_blank_is_true()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return '     '.blank();");
            Assert.IsTrue(result);           
        }

        [Test]
        public void if_string_contains_characters_blank_is_false()
        {
            var jint = new JintEngine(prototype);
            dynamic result = jint.Run(@"return '  klk  '.blank();");
            Assert.IsFalse(result);           
        }
    }
}
