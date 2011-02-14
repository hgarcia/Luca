using NUnit.Framework;

namespace Generators.Specs.Features 
{
    [TestFixture]
    public partial class CreateApplication 
    {
        
        [Test]
        public void OnAnEmptyFolder()
        {         
            Given_I_run_inside_an_empty_folder();        
            When_I_type("create-app");        
            Them_the_application_should_be_created();
        }
        
        [Test]
        public void OnANonEmptyFolder()
        {         
            Given_I_run_inside_a_non_empty_folder();        
            When_I_type("create-app");        
            Then_I_should_receive_a_message_that_contains("the folder is not empty");
        }
        
        [Test]
        public void OnANonEmptyFolderPassingAnApplicationName()
        {
            Given_I_run_inside_a_non_empty_folder();        
            When_I_type("create-app myapp");        
            Then_a_new_folder_named__should_be_created("myapp");        
            And_the_application_should_be_created();
        }
        
        [Test]
        public void PassingAnInvalidAppName()
        {         
            Given_I_run_inside_a_non_empty_folder();        
            When_I_type("create-app my app");        
            Then_I_should_receive_a_message_that_contains("invalid application name");
        }

    }
}
