using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Jint.Play
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tests = { "access-binary-trees" };
            // string[] tests = { "3d-cube", "3d-morph", "3d-raytrace", "access-binary-trees", "access-fannkuch", "access-nbody", "access-nsieve", "bitops-3bit-bits-in-byte", "bitops-bits-in-byte", "bitops-bitwise-and", "bitops-nsieve-bits", "controlflow-recursive", "crypto-aes", "crypto-md5", "crypto-sha1", "date-format-tofte", "date-format-xparb", "math-cordic", "math-partial-sums", "math-spectral-norm", "regexp-dna", "string-base64", "string-fasta", "string-tagcloud", "string-unpack-code", "string-validate-input" };

            var assembly = Assembly.Load("Jint.Tests");
            Stopwatch sw = new Stopwatch();

            foreach (var test in tests)
            {
                string script;

                try
                {
                    script = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.SunSpider." + test + ".js")).ReadToEnd();
                    if (String.IsNullOrEmpty(script))
                    {
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("{0}: ignored", test);
                    continue;
                }

                JintEngine jint = new JintEngine()
                    //.SetDebugMode(true)
                    .DisableSecurity();

                sw.Reset();
                sw.Start();

                jint.Run(script);

                Console.WriteLine("{0}: {1}ms", test, sw.ElapsedMilliseconds);
            }
        }
    }
}
