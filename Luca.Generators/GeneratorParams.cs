using System;
namespace Luca.Generators
{
    public abstract class GeneratorParams
    {
        private readonly string[] _args;

        protected GeneratorParams(string[] args)
        {
            if (args == null) throw new ArgumentNullException("args","You need to pass at least one argument.");
            _args = args;
            if (_args.Length > 0) Generator = _args[0];
            if (_args.Length > 1 && IsHelp(_args[1])) Help = true; 
        }

        private bool IsHelp(string arg)
        {
            var helpArg = arg.ToLower().Trim();
            return helpArg.Equals("--help") || helpArg.Equals("-h");
        }

        public bool Help { get; set; }
        public string Generator { get; set; }
    }
}