using System;
using System.IO;
using Noesis.Javascript;
using Jurassic;
using Owin;

namespace js_test
{
    public class SystemConsole
    {
        public void Print(string iString)
        {
            Console.WriteLine(iString);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Mustache_underscoreV8();
            //coffeeScriptJurassic();
            //coffeeScriptV8();
            //qunit();
            server();
        }

        private static void server()
        {
            Owin.Handlers.Kayak.Run(new Application(new ApplicationResponder(App)));
        }

        public class LucaApplication : IApplication
        {
            public IAsyncResult BeginInvoke(IRequest request, AsyncCallback callback, object state)
            {
                throw new NotImplementedException();
            }

            public IResponse EndInvoke(IAsyncResult result)
            {
                throw new NotImplementedException();
            }
        }

        public static IResponse App(IRequest rawRequest)
        {
            var request = new Request(rawRequest);
            var response = new Response().SetHeader("content-type", "text/html");
            //var errors = Lint.ErrorMessagesFor(rawRequest);
            
            //response.Write("{0} {1}\n\n", request.Method, request.Uri);

            //if (errors.Length == 0)
            //    response.Write("The IRequest is valid!");
            //else
            //    foreach (string message in errors)
            //       response.Write("Error: {0}\n", message);

            return response.Write(MustacheTemplate());
        }


        private static string MustacheTemplate()
        {
            var context = new JavascriptContext();
            //context.SetParameter("html", string.Empty);

            var mustache = File.ReadAllText("mustache.js");
            //var underscore = File.ReadAllText("underscore-min.js");
            var code =
                @"var view = {
                      title: ""Joe"",
                      calc: function() {
                        return 2 + 4;
                      }
                    }

            var template = ""{{title}} spends {{calc}}"";
            this.html = Mustache.to_html(template, view);";
            
            context.Run(mustache + code);
            return context.GetParameter("html").ToString();
        }


        private static void qunit()
        {
            var context = new JavascriptContext();
            context.SetParameter("console", new SystemConsole());
            var qunit = File.ReadAllText("qunit.js");
            var qunit_test = File.ReadAllText("qunit-test.js");
            var logger = "QUnit.log = function(details){console.Print(details.result + '\t' + details.message)};";
            var done =
                "QUnit.done = function(status){console.Print(status.failed + '\t' + status.passed  + '\t' + status.total  + '\t' + status.runtime)};";
            context.Run(qunit + logger + done + qunit_test);        
        }                                                    


        static void coffeeScriptV8()
        {
            var context = new JavascriptContext();

            var coffee = File.ReadAllText("coffee-script.js");
            var code = "this.code = CoffeeScript.compile(\"this.console = 'my name'\");";

            context.Run(coffee + code);

            var jsCode = context.GetParameter("code");
            Console.WriteLine(jsCode);
            context.Run(jsCode.ToString());
            Console.WriteLine(context.GetParameter("console"));
            Console.Read();
        }

        static void coffeeScriptJurassic()
        {
            var context = new ScriptEngine();
            var coffee = File.ReadAllText("coffee-script.js");
            var code = "this.code = CoffeeScript.compile(\"this.console = 'my name'\");";

            context.Execute(coffee + code);

            var jsCode  = context.GetGlobalValue("code");
            Console.WriteLine(jsCode);
            context.Execute(jsCode.ToString());
            Console.WriteLine(context.GetGlobalValue("console"));
            Console.Read();
        }

        static void Mustache_underscoreV8()
        {
            var context = new JavascriptContext();
            context.SetParameter("html", string.Empty);
            context.SetParameter("console", new SystemConsole());

            var mustache = File.ReadAllText("mustache.js");
            var underscore = File.ReadAllText("underscore-min.js");
            var code =
                @"var view = {
  title: ""Joe"",
  calc: function() {
    return 2 + 4;
  }
}

            var template = ""{{title}} spends {{calc}}"";
            html = Mustache.to_html(template, view);
            _.each([1, 2, 3], function(num){ console.Print(num); });";

            context.Run(underscore + mustache + code);

            Console.Write(context.GetParameter("html"));
            Console.Read();
        }
    }
}
