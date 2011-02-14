using NUnit.Framework;
using SharpTestsEx;

namespace Luca.Core.Specs.Units
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void when_passing_a_string_should_capitalize_it()
        {
            "capitalize".Capitalize().Should().Be.EqualTo("Capitalize");
        }

        [Test]
        public void when_passing_a_string_with_dashes_should_camel_case_it()
        {
            "capitalize-this".Capitalize().Should().Be.EqualTo("CapitalizeThis");
        }

        [Test]
        public void when_passing_an_empty_string_should_return_an_empty_string()
        {
            "".Capitalize().Should().Be.EqualTo("");
        }
    }
}