using System;
using System.Collections.Generic;
using System.IO;

namespace Luca.Generators
{
    public class Runner
    {
        public Runner(string[] args, TextWriter output, IDictionary<string, Type> generators)
        {
            try
            {
                var parameters = new AppGeneratorParams(args);
                var generator = (IGenerator)Activator.CreateInstance(generators["application"], parameters);
                if (parameters.Help)
                {
                    generator.Help(output);
                }else
                {
                    generator.Generate(output);
                }
            }
            catch (Exception exception)
            {
                output.WriteLine(exception.Message);
            }
        }
    }
}
