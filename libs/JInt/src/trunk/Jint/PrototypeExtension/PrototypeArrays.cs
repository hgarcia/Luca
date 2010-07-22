using System;
using Jint.Native;

namespace Jint.PrototypeExtension
{
    public class PrototypeArrays : IExtension
    {
        private JsConstructor Target { get; set; }
        public void ExtendTarget(JsConstructor target)
        {
            Target = target;
            Target.Prototype.DefineOwnProperty("collect", Target.Global.FunctionClass.New<JsObject>(CollectImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("clear", Target.Global.FunctionClass.New<JsArray>(ClearImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("clone", Target.Global.FunctionClass.New<JsArray>(CloneImpl), PropertyAttributes.DontEnum);
        }

        public JsInstance CollectImpl(JsObject target, JsInstance[] parameters)
        {
            if (parameters.Length == 0 || parameters[0].GetType() != typeof(JsFunction)) return target;
            var array = Target.Global.ArrayClass.New();
            var func = parameters[0];
            for (var i = 0; i < target.Length; i++)
            {
                Target.Global.Visitor.ExecuteFunction(func as JsFunction, target, new[] { target[i.ToString()] });
                array[i.ToString()] = Target.Global.Visitor.Returned;
            }
            return array;
        }

        public JsInstance CloneImpl(JsArray target, JsInstance[] parameters)
        {
            var result = Target.Global.ArrayClass.New();
            for (var i = 0; i < target.Length; i++)
            {
                result[i.ToString()] = target[i.ToString()];
            }
            return result;
        }

        public JsInstance ClearImpl(JsArray target, JsInstance[] parameters)
        {
            for (var i = target.Length - 1; i >= 0; i--)
            {
                target.Delete(i.ToString());
            }
            return target;
        }

        public Type TypeName
        {
            get { return typeof(JsArray); }
        }
    }
}
