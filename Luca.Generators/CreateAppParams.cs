using System.IO;

namespace Luca.Generators
{
    public class CreateAppParams : GeneratorParams
    {
        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _root;
        public string Root
        {
            get
            {
                if (string.IsNullOrEmpty(_root))
                {
                    _root = Directory.GetCurrentDirectory();
                }
                return _root;
            }
            set 
            { 
                _root = value; 
            }
        }

        public CreateAppParams(string[] args) : base(args)
        {
            if (args.Length > 1 && !Help) SetPath(args[1]);
        }

        private void SetPath(string argument)
        {
            if (!argument.StartsWith("-"))
            {
                Path = argument.Trim();
            }
        }
    }
}