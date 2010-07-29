using System;
using Jint;
using Jint.Native;

namespace Luca.Jint.PrototypeExtension
{
    public class PrototypeString : IExtension
    {
        private JsConstructor Target { get; set; }
        public void ExtendTarget(JsConstructor objectToExtend)
        {
            Target = objectToExtend;
            Target.Prototype.DefineOwnProperty("blank", Target.Global.FunctionClass.New<JsString>(BlankImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("capitalize", Target.Global.FunctionClass.New<JsString>(CapitalizeImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("empty", Target.Global.FunctionClass.New<JsString>(EmptyImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("endsWith", Target.Global.FunctionClass.New<JsString>(EndsWithImpl), PropertyAttributes.DontEnum);
        }

        public JsInstance EndsWithImpl(JsString target, JsInstance[] parameters)
        {
            if (parameters.Length == 0 || parameters[0].GetType() != typeof(JsString)) 
                return Target.Global.BooleanClass.New(false);

            return Target.Global.BooleanClass.New(target.Value.ToString().EndsWith(parameters[0].Value.ToString()));
        }

        public JsInstance EmptyImpl(JsString target)
        {
            return Target.Global.BooleanClass.New(target.Value.ToString().Length == 0);
        }

        public JsInstance CapitalizeImpl(JsString target)
        {
            var result = target.Value.ToString().ToLower();
            return Target.Global.StringClass.New(result.Substring(0, 1).ToUpper() + result.Substring(1));

        }

        public JsInstance BlankImpl(JsString target)
        {
            var result = target.Value.ToString().Trim().Length == 0;
            return Target.Global.BooleanClass.New(result);
        }

        public Type TypeName
        {
            get { return typeof(JsString); }
        }
    }
}
