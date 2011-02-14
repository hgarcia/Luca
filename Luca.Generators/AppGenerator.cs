using System.IO;
using System.Collections.Generic;

namespace Luca.Generators
{
    public class AppGenerator : IGenerator
    {
        private readonly AppGeneratorParams _appGeneratorParams;

        public AppGenerator(AppGeneratorParams appGeneratorParams)
        {
            _appGeneratorParams = appGeneratorParams;
        }

        public void Generate(TextWriter output)
        {
            if (!IsNewFolder() && !IsFolderEmpty())
            {
                output.WriteLine("The folder needs to be empty to create a Luca application.");
                return;
            }
            CreateApplication();
        }

        private void CreateApplication()
        {
            if (!IsNewFolder()) CreateFolder(_appGeneratorParams.Path);
            var appStructure = GetApplicationStructure();
            foreach (var path in appStructure)
            {
                CreateFolder(_appGeneratorParams.Path + "\\" + path);
            }
        }

        private IEnumerable<string> GetApplicationStructure()
        {
            var list = new List<string>
                           {
                               "libs",
                               "tools",
                               "app",
                               "app\\data",
                               "app\\services",
                               "app\\config",                               
                               "app\\controllers",
                               "app\\web",
                               "app\\web\\views",
                               "app\\web\\view-models",
                               "specs",
                               "logs",
                               "logs\\app",
                               "logs\\specs",
                               "logs\\builds",
                               "logs\\generators",
                               "logs\\migrations",
                               "reports",
                               "reports\\specs",
                               "reports\\behaviours",
                               "scripts",
                               "scripts\\builds",
                               "scripts\\generators",
                               "scripts\\migrations",
                               "build"
                           };
            return list;
        }

        private void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        private bool IsNewFolder()
        {
            return !new DirectoryInfo(_appGeneratorParams.Path).Exists;
        }
        
        private bool IsFolderEmpty()
        {
            var dirinfo = new DirectoryInfo(_appGeneratorParams.Path);
            return (dirinfo.Exists && dirinfo.GetFiles().Length == 0 && dirinfo.GetDirectories().Length == 0);
        }

        public void Help(TextWriter output)
        {
            output.WriteLine("usage");
            output.WriteLine("Luca create-app");
            output.WriteLine("Create the application structure in the folder where is been executed, the folder needs to be empty.");
            output.WriteLine("or");
            output.WriteLine("Luca create-app applicationName");
            output.WriteLine("Creates a folder by the applicationName and creates the structure inside.");
        }
    }
}