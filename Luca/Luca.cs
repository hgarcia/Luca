using System;
using Luca.Generators;
namespace Luca
{
    public class Luca
    {
        static void Main(string[] args)
        {
            try
            {
                new AppGenerator(new AppGeneratorParams(args)).Generate();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
