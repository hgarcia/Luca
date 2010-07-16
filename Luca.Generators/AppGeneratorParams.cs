using System;

namespace Luca.Generators
{
    public class AppGeneratorParams
    {
        public AppGeneratorParams(string[] args)
        {
            if (args == null) throw new ArgumentException("Missing argument. Please use the --help argument to learn more.");
            if (args[0] == "--help")
            {
                Help = true;
            }
            else
            {
                Path = args[0];
            }
        }

        public bool Help { get; private set; }
        public string Path { get; private set; }
    }
}