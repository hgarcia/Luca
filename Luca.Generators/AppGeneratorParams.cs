using System;

namespace Luca.Generators
{
    public class AppGeneratorParams
    {
        public AppGeneratorParams(string[] args)
        {
            if (args == null) throw new ArgumentException("Missing argument. Please use the --help argument to learn more.");
            Path = args[0];
        }

        public string Path { get; private set; }
    }
}