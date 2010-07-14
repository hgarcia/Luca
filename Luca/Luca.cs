namespace Luca
{
    public class Luca
    {
        static void Main(string[] args)
        {
            new AppGenerator(new AppGeneratorParams(args)).Generate();
        }
    }
}
