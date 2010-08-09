using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Jint.Expressions;
using System.IO;
using Jint.Native;
using System.Reflection;
using Jint.Debugger;
using System.Security.Permissions;
using System.Diagnostics;

namespace Jint.Tests
{
    [TestFixture]
    public class Fixtures
    {
        protected object Test(Options options, params string[] scripts)
        {
            var jint = new JintEngine()
                .SetFunction("assert", new Action<object, object>(Assert.AreEqual))
                .SetFunction("istrue", new Action<bool>(Assert.IsTrue))
                .SetFunction("isfalse", new Action<bool>(Assert.IsFalse))
                .SetFunction("print", new Action<string>(Console.WriteLine))
                .SetFunction("alert", new Action<string>(Console.WriteLine))
                .SetFunction("loadAssembly", new Action<string>(assemblyName => Assembly.Load(assemblyName)))
                .DisableSecurity();

            object result = null;

            var sw = new Stopwatch();
            sw.Start();

            foreach (var script in scripts)
                result = jint.Run(script);

            Console.WriteLine(sw.Elapsed);

            return result;
        }

        protected object Test(params string[] scripts)
        {
            return Test(Options.Ecmascript3 | Options.Strict, scripts);
        }

        [Test]
        public void ShouldReturnADynamicMethodFromAJsonObject()
        {
            var jint = new JintEngine();
            dynamic result =
                jint.Run(
                    @"function get() { return {ftuUrl: 'LaunchPage', idModifier: 'modifier', phrases: { free:'FREE', viewing_credit:'Viewing Credit', new_users:'new users', no_purchase_required:'no purchase required', start_here:'start here'} };} get();");
            Assert.AreEqual("LaunchPage",result.ftuUrl);
            Assert.AreEqual("FREE",result.phrases.free);
        }

        [Test]
        public void ShouldHandleSubstrWithOnlyTheStartProperly()
        {
            var engine = new JintEngine();
            var result = engine.Run(@" return 'hello'.substr(3);");
            Assert.AreEqual("llo", result);
        }

        [Test]
        public void ShouldHandleSubstrWithStartAndEnd()
        {
            var engine = new JintEngine();
            var result = engine.Run(@" return 'hello'.substr(3,2);");
            Assert.AreEqual("ll", result);
        }

        [Test]
        public void ShouldHandleDictionaryObjects()
        {
            var dic = new JsObject();
            dic["prop1"] = new JsNumber(1);
            Assert.IsTrue(dic.HasProperty(new JsString("prop1")));
            Assert.IsTrue(dic.HasProperty("prop1"));
            Assert.AreEqual(1, dic["prop1"].ToNumber());
        }

        [Test]
        public void ShouldRunInRun()
        {
            JintEngine engine = new JintEngine().AddPermission(new FileIOPermission(PermissionState.Unrestricted));
            engine.SetFunction("load", new Action<string>(delegate(string fileName) { using (var reader = File.OpenText(fileName)) { engine.Run(reader); } }));
            engine.SetFunction("print", new Action<string>(Console.WriteLine));
            engine.Run("var a='foo'; load('../../../include.js'); print(a);");
        }

        [Test]
        [ExpectedException(typeof(System.Security.SecurityException))]
        public void ShouldNotRunInRun()
        {
            JintEngine engine = new JintEngine().AddPermission(new FileIOPermission(PermissionState.None));
            engine.SetFunction("load", new Action<string>(delegate(string fileName) { using (var reader = File.OpenText(fileName)) { engine.Run(reader); } }));
            engine.SetFunction("print", new Action<string>(Console.WriteLine));
            engine.Run("var a='foo'; load('../../../include.js'); print(a);");
        }

        [Test]
        public void ShouldSupportCasting()
        {
            const string script = @";
                var value = Number(3);
                assert('number', typeof value);
                value = String(value); // casting
                assert('string', typeof value);
                assert('3', value);
            ";
            Test(script);
        }

        [Test]
        public void ShouldCompareNullValues()
        {
            string script = @";
                if(null == 1) 
                    assert(true, false); 

                if(null != null) 
                    assert(true, false); 
                
                assert(true, true);
            ";

            Test(script);
        }


        [Test]
        public void ShouldModifyIteratedCollection()
        {
            const string script = @";
                var values = [ 0, 1, 2 ];

                for (var v in values)
                {
                    values[v] = v * v;
                }

                assert(0, values[0]);
                assert(1, values[1]);
                assert(4, values[2]);
            ";

            Test(script);
        }

        [Test]
        public void ShouldHandleTheMostSimple()
        {
            Test("var i = 1; assert(1, i);");
        }

        [Test]
        public void ShouldHandleAnonymousFunctions()
        {
            var script = @"
                function oksa(x, y) { return x + y; }
                assert(3, oksa(1, 2));
            ";

            Test(script);
        }

        [Test]
        public void ShouldCompareWithNull()
        {
            var script = @"
                assert(false, null == undef);
            ";

            Test(script);
        }

        [Test]
        public void ShouldSupportUtf8VariableNames()
        {
            string script = @"
                var 経済協力開発機構 = 'a strange variable';
                var Sébastien = 'a strange variable';
                assert('a strange variable', 経済協力開発機構);
                assert('a strange variable', Sébastien);
                assert(undefined, sébastien);
            ";

            Test(script);
        }

        [Test]
        public void ShouldHandleReturnAsSeparator()
        {
            Test(@" var i = 1; assert(1, i) ");
        }

        [Test]
        public void ShouldHandleAssignment()
        {
            Test("var i; i = 1; assert(1, i);");
            Test("var i = 1; i = i + 1; assert(2, i);");
        }

        [Test]
        public void ShouldHandleEmptyStatement()
        {
            Assert.AreEqual(1d, new JintEngine().Run(";;;;var i = 1;;;;;;;; return i;;;;;"));
        }

        [Test]
        public void ShouldHandleFor()
        {
            Assert.AreEqual(9d, new JintEngine().Run("var j = 0; for(i = 1; i < 10; i = i + 1) { j = j + 1; } return j;"));
        }

        [Test]
        public void ShouldHandleSwitch()
        {
            Assert.AreEqual(1d, new JintEngine().Run("var j = 0; switch(j) { case 0 : j = 1; break; case 1 : j = 0; break; } return j;"));
            Assert.AreEqual(2d, new JintEngine().Run("var j = -1; switch(j) { case 0 : j = 1; break; case 1 : j = 0; break; default : j = 2; } return j;"));
        }

        [Test]
        public void ShouldHandleVariableDeclaration()
        {
            Assert.AreEqual(null, new JintEngine().Run("var i; return i;"));
            Assert.AreEqual(1d, new JintEngine().Run("var i = 1; return i;"));
            Assert.AreEqual(2d, new JintEngine().Run("var i = 1 + 1; return i;"));
            Assert.AreEqual(3d, new JintEngine().Run("var i = 1 + 1; var j = i + 1; return j;"));
        }

        [Test]
        public void ShouldHandleUndeclaredVariable()
        {
            Assert.AreEqual(1d, new JintEngine().Run("i = 1; return i;"));
            Assert.AreEqual(2d, new JintEngine().Run("i = 1 + 1; return i;"));
            Assert.AreEqual(3d, new JintEngine().Run("i = 1 + 1; j = i + 1; return j;"));
        }

        [Test]
        public void ShouldHandleStrings()
        {
            Assert.AreEqual("hello", new JintEngine().Run("return \"hello\";"));
            Assert.AreEqual("hello", new JintEngine().Run("return 'hello';"));

            Assert.AreEqual("hel'lo", new JintEngine().Run("return \"hel'lo\";"));
            Assert.AreEqual("hel\"lo", new JintEngine().Run("return 'hel\"lo';"));

            Assert.AreEqual("hel\"lo", new JintEngine().Run("return \"hel\\\"lo\";"));
            Assert.AreEqual("hel'lo", new JintEngine().Run("return 'hel\\'lo';"));

            Assert.AreEqual("hel\tlo", new JintEngine().Run("return 'hel\tlo';"));
            Assert.AreEqual("hel/lo", new JintEngine().Run("return 'hel/lo';"));
            Assert.AreEqual("hel//lo", new JintEngine().Run("return 'hel//lo';"));
            Assert.AreEqual("/*hello*/", new JintEngine().Run("return '/*hello*/';"));
            Assert.AreEqual("/hello/", new JintEngine().Run("return '/hello/';"));
        }

        [Test]
        public void ShouldHandleExternalObject()
        {
            Assert.AreEqual(3d,
                new JintEngine()
                .SetParameter("i", 1)
                .SetParameter("j", 2)
                .Run("return i + j;"));
        }

        public bool ShouldBeCalledWithBoolean(TypeCode tc)
        {
            return tc == TypeCode.Boolean;
        }

        [Test]
        [Ignore]
        public void ShouldHandleEnums()
        {
            Assert.AreEqual(TypeCode.Boolean,
                new JintEngine()
                .Run("System.TypeCode.Boolean"));

            Assert.AreEqual(true,
                new JintEngine()
                .SetParameter("clr", this)
                .Run("clr.ShouldBeCalledWithBoolean(System.TypeCode.Boolean)"));

        }

        [Test]
        public void ShouldHandleNetObjects()
        {
            Assert.AreEqual("1",
                new JintEngine() // call Int32.ToString() 
                .SetParameter("i", 1)
                .Run("return i.ToString();"));
        }

        [Test]
        public void ShouldReturnDelegateForFunctions()
        {
            string script = "ccat=function (arg1,arg2){ return arg1+' '+arg2; }";
            JintEngine engine = new JintEngine().SetFunction("print", new Action<string>(Console.WriteLine));
            engine.Run(script);
            Assert.AreEqual("Nicolas Penin", engine.CallFunction("ccat", "Nicolas", "Penin"));
        }

        [Test]
        public void ShouldHandleFunctions()
        {
            string square = @"function square(x) { return x * x; } return square(2);";
            string fibonacci = @"function fibonacci(n) { if (n == 0) return 0; else return n + fibonacci(n - 1); } return fibonacci(10); ";

            Assert.AreEqual(4d, new JintEngine().Run(square));
            Assert.AreEqual(55d, new JintEngine().Run(fibonacci));
        }

        [Test]
        public void ShouldCreateExternalTypes()
        {
            string stringBuilder = @"
                var sb = new System.Text.StringBuilder();
                sb.Append('hi, mom');
                sb.Append(3);	
                sb.Append(true);
                return sb.ToString();
                ";

            Assert.AreEqual("hi, mom3True", new JintEngine().Run(stringBuilder));
        }

        [Test]
        [ExpectedException(typeof(System.Security.SecurityException))]
        public void ShouldNotAccessClr()
        {
            string stringBuilder = @"
                var sb = new System.Text.StringBuilder();
                sb.Append('hi, mom');
                sb.Append(3);	
                sb.Append(true);
                return sb.ToString();
                ";
            var engine = new JintEngine();
            engine.AllowClr = false;
            Assert.AreEqual("hi, mom3True", engine.Run(stringBuilder));
        }

        [Test]
        public void ShouldHandleStaticMethods()
        {
            string script = @"
                var a = System.Int32.Parse('1');
                assert(1, ToDouble(a));
            ";

            Test(script);
        }

        [Test]
        public void ShouldParseMultilineStrings()
        {
            string script = @"
                assert('foobar', 'foo\
bar');
            ";

            Test(script);
        }

        [Test]
        public void ShouldEvaluateConsecutiveIfStatements()
        {
            string script = @"
                var a = 0;
                
                if(a > 0)
                    a = -1;
                else
                    a = 0;

                if(a > 1)
                    a = -1;
                else
                    a = 1;

                if(a > 2)
                    a = -1;
                else
                    a = 2;

                assert(2, a);
            ";

            Test(script);
        }

        private static JsString GiveMeJavascript(JsNumber number, JsInstance instance)
        {
            return new JsString(number + instance.ToString());
        }

        [Test]
        public void ShouldNotWrapJsInstancesIfExpected()
        {
            JintEngine engine = new JintEngine()
            .SetFunction("evaluate", new System.Func<JsNumber, JsInstance, JsString>(GiveMeJavascript));

            string script = @"
                var r = evaluate(3, [1,2]);
                return r;
            ";

            object r = engine.Run(script, false);

            Assert.IsTrue(r is JsString);
            Assert.AreEqual("31,2", r.ToString());
        }

        [Test]
        public void ShouldAssignBooleanValue()
        {
            string script = @"
                function check(x) {
                    assert(false, x);    
                }

                var a = false;
                check(a);                
            ";

            Test(script);
        }

        [Test]
        public void ShouldEvaluateFunctionDeclarationsFirst()
        {
            string script = @"
                var a = false;
                assert(false, a);
                test();
                assert(true, a);
                
                function test() {
                    a = true;
                }
            ";

            Test(script);
        }

        [Test]
        [ExpectedException(typeof(System.Security.SecurityException))]
        [Ignore]
        public void ShouldRunInLowTrustMode()
        {
            new JintEngine()
                .Run(@"
            var a = System.Convert.ToInt32(1);
            var b = System.IO.Directory.GetFiles(""c:"");");
        }

        [Test]
        public void ShouldAllowSecuritySandBox()
        {
            const string userDirectory = "c:\\temp";

            const string script = @"var b = System.IO.Directory.GetFiles(userDir);";

            new JintEngine()
                .SetParameter("userDir", userDirectory)
                .AddPermission(new FileIOPermission(FileIOPermissionAccess.PathDiscovery, userDirectory))
                .Run(script);
        }


        [Test]
        public void ShouldSetClrProperties()
        {
            // Ensure assembly is loaded
            var a = typeof(System.Windows.Forms.Form);
            var b = a.Assembly; // Force loading in Release mode, otherwise code is optimized
            string script = @"
                var frm = new System.Windows.Forms.Form();
                frm.Text = 'Test';
                return frm.Text; 
            ";

            var result = new JintEngine()
                .AddPermission(new UIPermission(PermissionState.Unrestricted))
                .Run(script);

            Assert.AreEqual("Test", result.ToString());
        }

        [Test]
        public void ShouldHandleCustomMethods()
        {
            Assert.AreEqual(9d, new JintEngine()
                .SetFunction("square", new System.Func<double, double>(a => { return a * a; }))
                .Run("return square(3);"));

            new JintEngine()
                .SetFunction("print", new Action<string>(s => { Console.Write(s); }))
                .Run("print('hello');");

            string script = @"
                function square(x) { 
                    return multiply(x, x); 
                }; 

                return square(4);
            ";

            var result =
                new JintEngine()
                .SetFunction("multiply", new System.Func<double, double, double>((x, y) => { return x * y; }))
                .Run(script);

            Assert.AreEqual(16d, result);
        }

        [Test]
        public void ShouldHandleDirectNewInvocation()
        {
            Assert.AreEqual("c", new JintEngine()
                .Run("return new System.Text.StringBuilder('c').ToString();"));
        }

        [Test]
        public void ShouldHandleGlobalVariables()
        {
            string program = @"
                var i = 3;
                function calculate() {
                    return i*i;
                }
                return calculate();
            ";

            Assert.AreEqual(9d, new JintEngine()
                .Run(program));
        }

        [Test]
        public void ShouldHandleObjectClass()
        {
            string program = @"
                var userObject = new Object();
                userObject.lastLoginTime = new Date();
                return userObject.lastLoginTime;
            ";

            object result = new JintEngine().Run(program);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(DateTime), result);
        }

        [Test]
        public void ShouldHandleIndexedProperties()
        {
            string program = @"
                var userObject = { };
                userObject['lastLoginTime'] = new Date();
                return userObject.lastLoginTime;
            ";

            object result = new JintEngine().Run(program);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(DateTime),result);
        }

        [Test]
        public void ShouldAssignProperties()
        {
            string script = @"
                function sayHi(x) {
                    alert('Hi, ' + x + '!');
                }

                sayHi.text = 'Hello World!';
                sayHi['text2'] = 'Hello World... again.';

                assert('Hello World!', sayHi['text']); 
                assert('Hello World... again.', sayHi.text2); 
                ";

            Test(script);
        }

        [Test]
        public void ShouldStoreFunctionsInArray()
        {
            string script = @"

                // functions stored as array elements
                var arr = [];
                arr[0] = function(x) { return x * x; };
                arr[1] = arr[0](2);
                arr[2] = arr[0](arr[1]);
                arr[3] = arr[0](arr[2]);
                
                // displays 256
                assert(256, arr[3]);
            ";

            Test(script);
        }

        [Test]
        [Ignore]
        public void ShouldNotConflictWithClrMethods()
        {
            string script = @"
                assert(1, System.Math.Min(1, 2));
                assert(2, System.Math.Max(1, 2));
            ";

            Test(script);
        }

        [Test]
        public void ShouldCreateObjectLiterals()
        {
            string script = @"
                var myDog = {
                    'name' : 'Spot',
                    'bark' : function() { return 'Woof!'; },
                    'displayFullName' : function() {
                        return this.name + ' The Alpha Dog';
                    },
                    'chaseMrPostman' : function() { 
                        // implementation beyond the scope of this article 
                    }    
                };
                assert('Spot The Alpha Dog', myDog.displayFullName()); 
                assert('Woof!', myDog.bark()); // Woof!
            ";

            Test(script);
        }

        [Test]
        public void ShouldHandleFunctionsAsObjects()
        {
            string script = @"
                // assign an anonymous function to a variable
                var greet = function(x) {
                    return 'Hello, ' + x;
                };

                assert('Hello, MSDN readers', greet('MSDN readers'));

                // passing a function as an argument to another
                function square(x) {
                    return x * x;
                }
                function operateOn(num, func) {
                    return func(num);
                }
                // displays 256
                assert(256, operateOn(16, square));

                // functions as return values
                function makeIncrementer() {
                    return function(x) { return x + 1; };
                }
                var inc = makeIncrementer();
                // displays 8
                assert(8, inc(7));
                ";

            Test(script);

            Test(@"var Test = {};
Test.FakeButton = function() { };
Test.FakeButton.prototype = {};
var fakeButton = new Test.FakeButton();");
        }

        [Test]
        public void ShouldOverrideDefaultFunction()
        {
            string script = @"

                // functions as object properties
                var obj = { 'toString' : function() { return 'This is an object.'; } };
                // calls obj.toString()
                assert('This is an object.', obj.toString());
            ";

            Test(script);
        }

        [Test]
        public void ShouldHandleFunctionConstructor()
        {
            string script = @"
                var func = new Function('x', 'return x * x;');
                var r = func(3);
                assert(9, r);
            ";

            Test(script);
        }

        [Test]
        public void ShouldContinueAfterFunctionCall()
        {
            string script = @"
                function fib(x) {
                    if (x==0) return 0;
                    if (x==1) return 1;
                    if (x==2) return 2;
                    return fib(x-1) + fib(x-2);
                }

                var x = fib(0);
                
                return 'beacon';
                ";

            Assert.AreEqual("beacon", Test(script).ToString());
        }

        [Test]
        public void ShouldRetainGlobalsThroughRuns()
        {
            JintEngine jint = new JintEngine();

            jint.Run("i = 3; function square(x) { return x*x; }");

            Assert.AreEqual(3d, jint.Run("return i;"));
            Assert.AreEqual(9d, jint.Run("return square(i);"));
        }

        [Test]
        public void ShouldDebugScripts()
        {
            JintEngine jint = new JintEngine()
            .SetDebugMode(true);
            jint.BreakPoints.Add(new BreakPoint(4, 22)); // return x*x;

            jint.Step += (sender, info) =>
            {
                Assert.IsNotNull(info.CurrentStatement);
            };

            bool brokeOnReturn = false;

            jint.Break += (sender, info) =>
            {
                Assert.IsNotNull(info.CurrentStatement);
                Assert.IsTrue(info.CurrentStatement is ReturnStatement);
                Assert.AreEqual(3, Convert.ToInt32(info.Locals["x"].Value));

                brokeOnReturn = true;
            };

            jint.Run(@"
                var i = 3; 
                function square(x) { 
                    return x*x; 
                }
                return square(i);
            ");

            Assert.IsTrue(brokeOnReturn);
        }

        [Test]
        public void ShouldBreakOnCondition()
        {
            JintEngine jint = new JintEngine()
            .SetDebugMode(true);
            jint.BreakPoints.Add(new BreakPoint(4, 22, "x == 2;")); // return x*x;

            jint.Step += (sender, info) =>
            {
                Assert.IsNotNull(info.CurrentStatement);
            };

            bool brokeOnReturn = false;

            jint.Break += (sender, info) =>
            {
                Assert.IsNotNull(info.CurrentStatement);
                Assert.IsTrue(info.CurrentStatement is ReturnStatement);
                Assert.AreEqual(2, Convert.ToInt32(info.Locals["x"].Value));

                brokeOnReturn = true;
            };

            jint.Run(@"
                var i = 3; 
                function square(x) { 
                    return x*x; 
                }
                
                square(1);
                square(2);
                square(3);
            ");

            Assert.IsTrue(brokeOnReturn);
        }

        [Test]
        public void ShouldHandleInlineCLRMethodCalls()
        {
            string script = @"
                var box = new Jint.Tests.Box();
                box.SetSize(ToInt32(100), ToInt32(100));
                assert(100, Number(box.Width));
                assert(100, Number(box.Height));
            ";
            Test(script);
        }

        [Test]
        public void ShouldHandleStructs()
        {
            string script = @"
                var size = new Jint.Tests.Size();
                size.Width = 10;
                assert(10, Number(size.Width));
                assert(0, Number(size.Height));
            ";
            Test(script);
        }

        [Test]
        public void ShouldHandleFunctionScopes()
        {
            string script = @"
                var success = false;
                $ = {};

                (function () { 
                    
                    function a(x) {
                        success = x;                                   
                    }
                    
                    $.b = function () {
                        a(true);
                    }

                }());
                
                $.b();

                ";

            Test(script);
        }

        [Test]
        public void ShouldHandleLoopScopes()
        {
            string script = @"
                f = function() { var i = 10; }
                for(var i=0; i<3; i++) { f(); }
                assert(3, i);

                f = function() { i = 10; }
                for(i=0; i<3; i++) { f(); }
                assert(11, i);

                f = function() { var i = 10; }
                for(i=0; i<3; i++) { f(); }
                assert(3, i);

                f = function() { i = 10; }
                for(var i=0; i<3; i++) { f(); }
                assert(11, i);
                ";

            Test(script);
        }

        [Test]
        [Ignore]
        public void ShouldExecuteEnv()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var jintEnv = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.env.env.jint.js")).ReadToEnd();
            var env = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.env.env1.0.js")).ReadToEnd();

            string google = @"window.location=""http://n.yaronet.com""; print(document.title)";

            Test(jintEnv, env, google);
        }

        [Test]
        public void ShouldExecuteSingleScript()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var program = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.Scripts.PrototypeInheritance.js")).ReadToEnd();
            Test(program);
        }

        [Test]
        public void ShouldCascadeEquals()
        {
            Test("a=b=1; assert(1,a);assert(1,b);");
        }

        [Test]
        public void ShouldParseScripts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var resx in assembly.GetManifestResourceNames())
            {
                // Ignore scripts not in /Scripts
                if (!resx.Contains(".Parse"))
                {
                    continue;
                }

                var program = new StreamReader(assembly.GetManifestResourceStream(resx)).ReadToEnd();
                if (program.Trim() == String.Empty)
                {
                    continue;
                }
                System.Diagnostics.Trace.WriteLine(Path.GetFileNameWithoutExtension(resx));
                JintEngine.Compile(program, true);
            }
        }

        [Test]
        [Ignore]
        public void ShouldExecuteTestScripts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            List<string> resources = new List<string>();
            foreach (var resx in assembly.GetManifestResourceNames())
            {
                // Ignore scripts not in /Scripts
                if (!resx.Contains(".Scripts."))
                {
                    continue;
                }

                resources.Add(resx);
            }

            foreach (var resx in resources)
            {
                var program = new StreamReader(assembly.GetManifestResourceStream(resx)).ReadToEnd();

                System.Diagnostics.Trace.WriteLine(Path.GetFileNameWithoutExtension(resx));
                Test(program);
            }
        }

        [Test]
        public void ShouldHandleNativeTypes()
        {

            JintEngine jint = new JintEngine()
            .SetDebugMode(true)
            .SetFunction("assert", new System.Action<object, object>(Assert.AreEqual))
            .SetFunction("print", new Action<string>(System.Console.WriteLine))
            .SetParameter("foo", "native string");

            jint.Run(@"
                assert(7, foo.indexOf('string'));            
            ");
        }

        [Test]
        public void ShouldExecuteMozillaTestsScripts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var shell = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.shell.js")).ReadToEnd();
            var extensions = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.extensions.js")).ReadToEnd();

            List<string> resources = new List<string>();
            foreach (var resx in assembly.GetManifestResourceNames())
            {
                // Ignore scripts not in /Scripts
                if (!resx.Contains(".ecma_3.") || !resx.Contains("Array"))
                {
                    continue;
                }

                resources.Add(resx);
            }

            resources.Sort();

            //Run the shell first if defined
            string additionalShell = null;
            if (resources[resources.Count - 1].EndsWith("shell.js"))
            {
                additionalShell = resources[resources.Count - 1];
                resources.RemoveAt(resources.Count - 1);
                additionalShell = new StreamReader(assembly.GetManifestResourceStream(additionalShell)).ReadToEnd();
            }

            foreach (var resx in resources)
            {
                var program = new StreamReader(assembly.GetManifestResourceStream(resx)).ReadToEnd();
                Console.WriteLine(Path.GetFileNameWithoutExtension(resx));

                JintEngine jint = new JintEngine()
                .SetDebugMode(true)
                .SetFunction("print", new Action<string>(System.Console.WriteLine));

                jint.Run(extensions);
                jint.Run(shell);
                jint.Run("test = _test;");
                if (additionalShell != null)
                {
                    jint.Run(additionalShell);
                }

                try
                {
                    jint.Run(program);
                }
                catch (Exception e)
                {
                    jint.Run("print('Error in : ' + gTestfile)");
                    Console.WriteLine(e.Message);
                }
            }
        }

        [Test]
        [Ignore]
        public void ShouldExecuteEcmascript5TestsScripts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var extensions = new StreamReader(assembly.GetManifestResourceStream("Jint.Tests.extensions.js")).ReadToEnd();

            List<string> resources = new List<string>();
            foreach (var resx in assembly.GetManifestResourceNames())
            {
                // Ignore scripts not in /Scripts
                if (!resx.Contains(".ecma_5.") || resx.Contains(".Scripts."))
                {
                    continue;
                }

                resources.Add(resx);
            }

            resources.Sort();

            //Run the shell first if defined
            string additionalShell = null;
            if (resources[resources.Count - 1].EndsWith("shell.js"))
            {
                additionalShell = resources[resources.Count - 1];
                resources.RemoveAt(resources.Count - 1);
                additionalShell = new StreamReader(assembly.GetManifestResourceStream(additionalShell)).ReadToEnd();
            }

            foreach (var resx in resources)
            {
                var program = new StreamReader(assembly.GetManifestResourceStream(resx)).ReadToEnd();
                Console.WriteLine(Path.GetFileNameWithoutExtension(resx));

                JintEngine jint = new JintEngine()
                .SetDebugMode(true)
                .SetFunction("print", new Action<string>(System.Console.WriteLine));

                jint.Run(extensions);
                //jint.Run(shell);
                jint.Run("test = _test;");
                if (additionalShell != null)
                {
                    jint.Run(additionalShell);
                }

                try
                {
                    jint.Run(program);
                }
                catch (Exception e)
                {
                    jint.Run("print('Error in : ' + gTestfile)");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public List<int> FindAll(List<int> source, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (int i in source)
            {
                var obj = predicate(i);

                if ((bool)obj)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        [Test]
        public void ShouldHandleStrictMode()
        {
            //Strict mode enabled
            JintEngine engine = new JintEngine(Options.Strict)
            .SetFunction("assert", new System.Action<object, object>(Assert.AreEqual))
            ;
            engine.Run(@"
            try{
                var test1=function(eval){}
                //should not execute the next statement
                assert(true, false);
            }
            catch(e){
                assert(true, true);
            }
            try{
                function test2(eval){}
                //should not execute the next statement
                assert(true, false);
            }
            catch(e){
                assert(true, true);
            }");
            //Strict mode disnabled
            engine = new JintEngine(Options.Ecmascript3)
            .SetFunction("assert", new System.Action<object, object>(Assert.AreEqual))
            ;
            engine.Run(@"
            try{
                var test1=function(eval){}
                //should not execute the next statement
                assert(true, true);
            }
            catch(e){
                assert(true, false);
            }
            try{
                function test2(eval){}
                //should not execute the next statement
                assert(true, true);
            }
            catch(e){
                assert(true, false);
            }");
        }

        [Test]
        public void ShouldHandleMultipleRunsInSameScope()
        {
            JintEngine jint = new JintEngine()
                .SetFunction("assert", new System.Action<object, object>(Assert.AreEqual))
                .SetFunction("print", new Action<string>(System.Console.WriteLine));

            jint.Run(@" var g = []; function foo() { assert(0, g.length); }");
            jint.Run(@" foo();");
        }

        [Test]
        public void ShouldReturnMultiDimensionalArray()
        {
            var values = new [] { new[]{1, 2, 3}, new[]{ 4,5} };
            var jint = new JintEngine()
            .SetDebugMode(true)
            .SetParameter("a", values);
            dynamic result = jint.Run("return a;");
            Assert.AreEqual(3, result[0][2]);  
            Assert.AreEqual(4,result[1][0]);
        }

        [Test]
        public void ShouldHandleClrArrays()
        {
            int[] values = new int[] { 2, 3, 4, 5, 6, 7 };
            JintEngine jint = new Jint.JintEngine()
            .SetDebugMode(true)
            .SetParameter("a", values);
            var result1 = jint.Run("return a[1];");
            Assert.AreEqual(3, result1);
            jint.Run("a[1] = 4");
            var result2 = jint.Run("return a[1];");
            Assert.AreEqual(4, result2);
            Assert.AreEqual(4, values[1]);

        }

        [Test]
        public void ShouldHandleClrDictionaries()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("a", 1);
            dic.Add("b", 2);
            dic.Add("c", 3);

            Jint.JintEngine jint = new Jint.JintEngine()
            .SetDebugMode(true)
            .SetParameter("dic", dic);

            Assert.AreEqual(1, jint.Run("return dic['a'];"));
            jint.Run("dic['a'] = 4");
            Assert.AreEqual(4, jint.Run("return dic['a'];"));
            Assert.AreEqual(4, dic["a"]);
        }

        [Test]
        [Ignore]
        public void ShouldEvaluateIndexersAsClrProperties()
        {
            var box = new Box() { Width = 10, Height = 20 };

            Jint.JintEngine jint = new Jint.JintEngine()
            .SetDebugMode(true)
            .SetParameter("box", box);

            Assert.AreEqual(10, jint.Run("return box.Width"));
            Assert.AreEqual(10, jint.Run("return box['Width']"));
            jint.Run("box['Height'] = 30;");

            Assert.AreEqual(30, box.Height);

            jint.Run("box.Height = 18;");
            Assert.AreEqual(18, box.Height);
        }

        [Test]
        [Ignore]
        public void ShouldEvaluateIndexersAsClrFields()
        {
            var box = new Box() { width = 10, height = 20 };

            JintEngine jint = new Jint.JintEngine().AddPermission(new System.Security.Permissions.ReflectionPermission(PermissionState.Unrestricted));
            jint.SetDebugMode(true);
            jint.SetParameter("box", box);

            Assert.AreEqual(10, jint.Run("return box.width"));
            Assert.AreEqual(10, jint.Run("return box['width']"));
            jint.Run("box['height'] = 30;");

            Assert.AreEqual(30, box.height);

            jint.Run("box.height = 18;");

            Assert.AreEqual(18, box.height);

        }

        [Test]
        [Ignore]
        public void ShouldFindOverloadWithNullParam()
        {
            var box = new Box() { Width = 10, Height = 20 };

            Jint.JintEngine jint = new Jint.JintEngine()
            .SetDebugMode(true)
            .SetFunction("assert", new System.Action<object, object>(Assert.AreEqual))
            .SetParameter("box", box);

            jint.Run(@"
                assert(1, Number(box.Foo(1)));
                assert(2, Number(box.Foo(2, null)));    
            ");
        }

        [Test]
        public void ShouldHandlePropertiesOnFunctions()
        {
            Test(@"
                HelloWorld.webCallable = 'GET';
                function HelloWorld()
                {
                    return 'Hello from Javascript!';
                }
                
                assert('GET', HelloWorld.webCallable);
            ");

        }

        [Test]
        [Ignore]
        public void ShouldNotThrowOverflowExpcetion()
        {
            var jint = new JintEngine();
            jint.SetParameter("box", new Box());
            jint.Run("box.Write(new Date);");

        }

        [Test]
        public void ShouldNotReproduceBug85418()
        {
            var engine = new JintEngine();
            engine.SetParameter("a", 4);
            Assert.AreEqual(4, engine.Run("a"));
            Assert.AreEqual(4d, engine.Run("4"));
            Assert.AreEqual(true, engine.Run("a == 4"));
            Assert.AreEqual(true, engine.Run("4 == 4"));
            Assert.AreEqual(true, engine.Run("a == a"));
        }

        [Test]
        public void ShouldShortCircuitBooleanOperators()
        {
            Test(@"
                var called = false;
                function dontcallme() {
                    called = true;
                }
                
                assert(true, true || dontcallme());
                assert(false, called);

                assert(false, false && dontcallme());
                assert(false, called);

                ");
        }
    }

    public struct Size
    {
        public int Width;
        public int Height;
    }

    public class Box
    {
        private readonly StringBuilder sb = new StringBuilder();
        // public fields
        public int width;
        public int height;

        // public properties
        public int Width { get; set; }
        public int Height { get; set; }

        public void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Foo(int a, object b)
        {
            return a;
        }

        public int Foo(int a)
        {
            return a;
        }

        public void Write(object value)
        {
            //sb.Append(value);
        }
    }
}