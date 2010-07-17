using System;
using System.Text;
using Jint;
using System.IO;

namespace TestImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //consoleWithNetAssembly();
            underscoreJs();
        }

        private static void underscoreJs()
        {
            var js = new JintEngine();
            var sb = new StringBuilder();
            js.SetParameter("response", sb);
            js.SetParameter("request", Console.In);

            var script = File.ReadAllText("prototype.js");
            script += @"var a = [1,2,3,4,5];
response.Append(a.first());";
            js.Run(script);
            Console.Write(sb);
            Console.ReadLine();
        }

        private static void consoleWithNetAssembly()
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
