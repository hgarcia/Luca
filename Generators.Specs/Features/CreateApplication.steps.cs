using System;
using System.IO;
using System.Linq;
using System.Text;
using Luca.Generators;
using NUnit.Framework;
using SharpTestsEx;

namespace Generators.Specs.Features 
{
    public partial class CreateApplication 
    {
        [TearDown]
        public void TearDown()
        {
            Directory.Delete(_path,true);
        }

        [SetUp]
        public void SetUp()
        {
            _folderName = DateTime.Now.ToString("yyyyMMdd");
            _path = Directory.GetCurrentDirectory() + "/" + _folderName;
        }

        private string _folderName = string.Empty;
        private string _path = string.Empty;
        private CreateAppParams _appParams;
        public string[] _folders;

        private void Given_I_run_inside_an_empty_folder()
        {            
            Directory.CreateDirectory(_path);
        }

        private void When_I_type(string command)
        {
            _appParams = new CreateAppParams(command.Split(' '));
            if (String.IsNullOrEmpty(_appParams.Path)) _appParams.Path = _folderName;
        }

        private void Them_the_application_should_be_created()
        {
            new CreateAppGenerator(_appParams).Generate(new StringWriter());
            _folders = Directory.GetDirectories(_appParams.Path);
            _folders.Length.Should().Be.EqualTo(8);           
        }

        private void Given_I_run_inside_a_non_empty_folder()
        {
            Directory.CreateDirectory(_path);
            Directory.CreateDirectory(_path + "/non-empty");
        }

        private void Then_I_should_receive_a_message_that_contains(string message)
        {
            var builder = new StringBuilder();
            new CreateAppGenerator(_appParams).Generate(new StringWriter(builder));
            builder.ToString().Should().Contain(message);           
        }

        private void Then_a_new_folder_named__should_be_created(string nameOfApp)
        {
            new CreateAppGenerator(_appParams).Generate(new StringWriter());
            _folders = Directory.GetDirectories(_appParams.Root);
            _folders.ToList().Find(it => it.ToLower().Contains(nameOfApp)).Should().Not.Be.Empty();          
        }

        private void And_the_application_should_be_created()
        {
            Directory.GetDirectories(_appParams.Path).Length.Should().Be.EqualTo(8);
        }
    }
}
