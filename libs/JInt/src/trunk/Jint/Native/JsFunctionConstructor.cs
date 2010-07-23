using System;
using System.Collections.Generic;
using Jint.Expressions;

namespace Jint.Native
{
    [Serializable]
    public class JsFunctionConstructor : JsConstructor
    {
        public JsFunctionConstructor(IGlobal global)
            : base(global)
        {
            Prototype = new JsFunctionWrapper(arguments => JsUndefined.Instance) { Prototype = global.ObjectClass.Prototype, Name = "Function" };
            Name = "Function";
        }

        public override void InitPrototype(IGlobal global)
        {
            ((JsFunction)Prototype).Scope = global.ObjectClass.Scope;
            Prototype.DefineOwnProperty("constructor", this, PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty(CALL, new JsCallFunction(this), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty(APPLY, new JsApplyFunction(this), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty("toString", New<JsDictionaryObject>(ToString2), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty("toLocaleString", New<JsDictionaryObject>(ToString2), PropertyAttributes.DontEnum);
            Prototype.DefineOwnProperty("length", new PropertyDescriptor<JsObject>(global, Prototype, "length", GetLengthImpl, SetLengthImpl));
            Extend<JsFunction>();
        }

        public JsInstance GetLengthImpl(JsDictionaryObject target)
        {
            return Global.NumberClass.New(target.Length);
        }

        public JsInstance SetLengthImpl(JsInstance target, JsInstance[] parameters)
        {
            var number = (int)parameters[0].ToNumber();

            if (number < 0 || double.IsNaN(number) || double.IsInfinity(number))
            {
                throw new JsException(Global.RangeErrorClass.New("invalid length"));
            }

            var obj = (JsDictionaryObject)target;
            obj.Length = number;

            return parameters[0];
        }

        public JsInstance GetLength(JsDictionaryObject target)
        {
            return Global.NumberClass.New(target.Length);
        }

        public JsFunction New()
        {
            var function = new JsFunction();
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }

        public JsFunction New<T>(Func<T, JsInstance> impl) where T : JsInstance
        {
            JsFunction function = new ClrImplDefinition<T>(impl);
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }
        public JsFunction New<T>(Func<T, JsInstance> impl, int size) where T : JsInstance
        {
            JsFunction function = new ClrImplDefinition<T>(impl, size);
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }

        public JsFunction New<T>(Func<T, JsInstance[], JsInstance> impl) where T : JsInstance
        {
            JsFunction function = new ClrImplDefinition<T>(impl);
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }
        public JsFunction New<T>(Func<T, JsInstance[], JsInstance> impl, int size) where T : JsInstance
        {
            JsFunction function = new ClrImplDefinition<T>(impl, size);
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }

        public JsFunction New(Delegate d)
        {
            JsFunction function = new ClrFunction(d);
            function.Prototype = Global.ObjectClass.New(function);
            function.Scope.Prototype = Prototype;
            return function;
        }

        public override JsInstance Execute(IJintVisitor visitor, JsDictionaryObject that, JsInstance[] parameters)
        {
            var instance = New();
            instance.Arguments = new List<string>();

            for (var i = 0; i < parameters.Length - 1; i++)
            {
                var arguments = parameters[i].ToString();

                foreach (var argument in arguments.Split(','))
                {
                    instance.Arguments.Add(argument.Trim());
                }
            }

            if (parameters.Length >= 1)
            {
                var program = JintEngine.Compile(parameters[parameters.Length - 1].Value.ToString(), visitor.DebugMode);
                instance.Statement = new BlockStatement { Statements = program.Statements };
            }

            return visitor.Return(instance);
        }

        public JsInstance ToString2(JsDictionaryObject target, JsInstance[] parameters)
        {
            return Global.StringClass.New(target.ToString());
        }
    }
}
