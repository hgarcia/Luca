using System;
using System.Collections.Generic;
using Luca.Generators;

namespace Luca
{
    public class Luca
    {
        static void Main(string[] args)
        {
            new Runner(args, Console.Out, getGenerators());
        }

        static IDictionary<string, Type> getGenerators()
        {
            return new Dictionary<string, Type>
                       {
                           {"application", typeof(AppGenerator)}
                       };
        }
    }
}
