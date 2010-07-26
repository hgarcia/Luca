using System;
using Jint.Native;

namespace Jint.PrototypeExtension
{
    public class PrototypeString : IExtension
    {
        private JsConstructor Target { get; set; }
        public void ExtendTarget(JsConstructor objectToExtend)
        {
            Target = objectToExtend;
            Target.Prototype.DefineOwnProperty("blank", Target.Global.FunctionClass.New<JsString>(BlankImpl), PropertyAttributes.DontEnum);
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
