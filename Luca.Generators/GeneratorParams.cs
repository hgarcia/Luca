namespace Luca.Generators
{
    public abstract class GeneratorParams
    {
        private readonly string[] _args;

        protected GeneratorParams(string[] args)
        {
            _args = args;
        }
    }
}