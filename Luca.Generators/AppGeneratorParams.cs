using System;

namespace Luca
{
    public class AppGeneratorParams
    {
        private readonly string[] _args;

        public AppGeneratorParams(string[] args)
        {
            if(args == null) throw new ArgumentNullException();
            Path = args[0];
        }

        public string Path { get; private set; }
    }
}