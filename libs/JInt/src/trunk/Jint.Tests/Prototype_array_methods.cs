using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jint.Tests
{
    [TestClass]
    public class Prototype_array_methods
    {
        [TestMethod]
        public void Array_should_support_collect_method()
        {
            var jint = new JintEngine();
            dynamic result = jint.Run(@"var ar = [1,2,3,4];
return ar.collect(function(a){
    return a+1;
});");
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3,result[1]);
            Assert.AreEqual(4, result[2]);
            Assert.AreEqual(5, result[3]);
        }
    }
}
