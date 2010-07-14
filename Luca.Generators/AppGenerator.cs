using System;
using System.IO;

namespace Luca
{
    public class AppGenerator
    {
        private readonly AppGeneratorParams _appGeneratorParams;

        public AppGenerator(AppGeneratorParams appGeneratorParams)
        {
            _appGeneratorParams = appGeneratorParams;
        }

        public void Generate()
        {
            if (!IsNewFolder() && !IsFolderEmpty())
                throw new IOException("A new application needs to be created inside an empty folder. The folder needs to be empty");

        }

        private void CreateApplication()
        {
            throw new NotImplementedException();
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
    }
}