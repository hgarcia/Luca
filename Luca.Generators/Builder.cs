using System;
using System.Linq;
using Luca.Core;

namespace Luca.Generators
{
    public static class Builder
    {
        public static GeneratorParams CreateParams(string[] args)
        {
            if (args == null || args.Length == 0) throw new MissingGeneratorException();
            if (args.Length == 1) return new NullParams(args);
            var generatorName = "Luca.Generators." + args[0].Capitalize() + "Params";
            var extraParams = args.ToList().Skip(1).ToArray();
            var type = Type.GetType(generatorName);
            var ctor = type.GetConstructor(new Type[] { typeof(string[]) });
            var generatorParams = ctor.Invoke(new[]{extraParams});

            return generatorParams as GeneratorParams;
        }
    }
}