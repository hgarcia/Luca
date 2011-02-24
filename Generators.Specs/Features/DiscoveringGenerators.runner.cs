using NUnit.Framework;

namespace Generators.Specs.Features 
{
    [TestFixture]
    public partial class DiscoveringGenerators 
    {
        
        [Test]
        public void PassingARealCommand()
        {         
            When_passing_a_real_command();
            Then_should_create_the_proper_command_parser();
        }
        
        [Test]
        public void PassingABadCommand()
        {         
            When_passing_a_non_existent_command();        
            Then_should_return_a_message();
        }

    }
}
