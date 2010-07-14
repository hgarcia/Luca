using System;
using System.Text;
using Jint;

namespace TestImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var js = new JintEngine();
            var sb = new StringBuilder();
            js.SetParameter("sb", sb);
            js.Run(
                @"
  sb.Append('hi, mom');
  sb.Append(3);	
  sb.Append(true);
");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
