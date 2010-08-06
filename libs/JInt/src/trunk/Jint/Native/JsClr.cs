using System;
using System.Collections.Generic;
using System.Reflection;
using Jint.Expressions;

namespace Jint.Native
{
    [Serializable]
    public sealed class JsClr : JsObject
    {
        private readonly IGlobal _global;
        private readonly IPropertyGetter _propertyGetter;
        private readonly IFieldGetter _fieldGetter;

        public JsClr(IJintVisitor visitor)
        {
            _global = visitor.Global;
            _propertyGetter = visitor.PropertyGetter;
            _fieldGetter = visitor.FieldGetter;
            value = null;

        }

        public JsClr(IJintVisitor visitor, object clr)
            : this(visitor)
        {
            value = clr;
            if (value != null)
            {
                if (value is System.Collections.IEnumerable)
                    clrCountProperty = _propertyGetter.GetValue(value, "Count");
                else
                {
                    //properties = new List<string>();
                    foreach (PropertyInfo pi in value.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                    {
                        DefineOwnProperty(pi.Name, new ClrPropertyDescriptor(_propertyGetter, _global, this, pi.Name));
                    }
                    foreach (FieldInfo pi in value.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public))
                    {
                        DefineOwnProperty(pi.Name, new ClrFieldDescriptor(_fieldGetter, _global, this, pi.Name));
                    }
                    ClrMethodDescriptor cmd = null;
                    foreach (MethodInfo mi in value.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
                    {
                        if (cmd == null || cmd.Name != mi.Name)
                            DefineOwnProperty(mi.Name, cmd = new ClrMethodDescriptor(this, mi.Name));
                    }
                }
            }
        }

        public override bool IsClr
        {
            get { return true; }
        }

        public override bool HasOwnProperty(string key)
        {
            if (base.HasOwnProperty(key))
                return true;
            if (properties == null)
                return false;
            Descriptor d;
            return properties.TryGet(key, out d);
        }

        //List<string> properties = null;

        private PropertyInfo clrCountProperty;

        public override int Length
        {
            get
            {
                if (clrCountProperty != null)
                    return (int)clrCountProperty.GetValue(value, null);
                return base.Length;
            }
            set
            {
                base.Length = value;
            }
        }

        public override bool ToBoolean()
        {
            if (value == null)
                return false;
            if (value is string)
                return !string.IsNullOrEmpty((string)value);
            if (value is IConvertible)
                return Convert.ToBoolean(value);
            return true;
        }

        public override double ToNumber()
        {
            if (value == null)
                return 0;
            if (value is IConvertible)
                return Convert.ToDouble(value);
            return double.NaN;
        }

        public override string ToString()
        {
            if (value == null)
                return null;
            if (value is IConvertible)
                return Convert.ToString(value);
            return value.ToString();
        }

        public const string TYPEOF = "clr";

        public override string Class
        {
            get
            {
                if (Prototype == _global.BooleanClass.Prototype)
                    return JsBoolean.TYPEOF;
                if (Prototype == _global.DateClass.Prototype)
                    return JsDate.TYPEOF;
                if (Prototype == _global.NumberClass.Prototype)
                    return JsNumber.TYPEOF;
                if (Prototype == _global.StringClass.Prototype)
                    return JsString.TYPEOF;
                return TYPEOF;
            }
        }

        public override object Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Converts a JsInstance object to its CLR equivalence
        /// </summary>
        /// <param name="parameter">The object to convert</param>
        /// <returns>A CLR object</returns>
        public static dynamic ConvertParameter(JsInstance parameter)
        {
            if (parameter.Class != JsFunction.TYPEOF && parameter.Class != JsArray.TYPEOF && parameter.Class != JsObject.TYPEOF)
            {
                return parameter.Value;
            }
            if (parameter == JsNull.instance)
            {
                return null;
            }
            if (parameter.IsClr)
                return parameter.Value;

            var constructor = ((JsDictionaryObject)parameter)["constructor"] as JsFunction;
            if (constructor == null)
                return parameter;
            switch (constructor.Name)
            {
                case "Date":
                    return JsDateConstructor.CreateDateTime(parameter.ToNumber());
                case "String":
                case "RegExp":
                case "Number":
                    return parameter.Value;
                case "Array":
                    if (parameter.Class == JsFunction.TYPEOF)
                        return parameter;
                    var array = new object[((JsObject)parameter).Length];
                    foreach (KeyValuePair<string, JsInstance> key in (JsObject)parameter)
                    {
                        int index;
                        if (int.TryParse(key.Key, out index))
                        {
                            array[index] = ConvertParameters(key.Value)[0];
                        }
                    }
                    return new System.Collections.ArrayList(array);
                case "Object":
                    if (parameter.Class == JsFunction.TYPEOF)
                        return parameter;
                    if (parameter.Value != null)
                        return parameter.Value;

                    var result = jsInstanceToDynamic((JsObject)parameter,  new JsonExpando());
                    return result;
                default:
                    return parameter;
            }
        }


        private static dynamic jsInstanceToDynamic(JsObject jsObject, JsonExpando result)
        {
            var props = jsObject.properties;
            foreach (var prop in props)
            {
                if (prop.Value.Value.GetType() == typeof(JsObject))
                {
                    result.SetMember(prop.Key, jsInstanceToDynamic((JsObject) prop.Value.Value, new JsonExpando()));
                }
                else
                {
                    result.SetMember(prop.Key, prop.Value.ToSource());
                }
            }
            return result;
        }

        /// <summary>
        /// Converts a set of JsInstance objects to their CLR equivalences
        /// </summary>
        /// <param name="parameters">The objects to convert</param>
        /// <returns>An array of CLR object</returns>
        public static object[] ConvertParameters(params JsInstance[] parameters)
        {
            var clrParameters = new object[parameters.Length];
            for (var j = 0; j < clrParameters.Length; j++)
            {
                // don't convert JsFunction as they will be translated to Delegates later
                clrParameters[j] = ConvertParameter(parameters[j]);
            }
            return clrParameters;
        }

        public static JsInstance[] ConvertParametersBack(IJintVisitor visitor, object[] args)
        {
            var jsParameters = new JsInstance[args.Length];
            for (var j = 0; j < jsParameters.Length; j++)
            {
                // don't convert JsFunction as they will be translated to Delegates later
                jsParameters[j] = ConvertParameterBack(visitor, args[j]);
            }
            return jsParameters;
        }

        public static JsInstance ConvertParameterBack(IJintVisitor visitor, object parameter)
        {
            if (parameter == null)
            {
                return JsNull.instance;
            }
            if (parameter.GetType().IsArray)
            {
                var jsArray = visitor.Global.ArrayClass.New();
                var index = -1;

                foreach (var value in (System.Collections.IEnumerable)parameter)
                {
                    jsArray[(index++).ToString()] = ConvertParameterBack(visitor, value);
                }
                return jsArray;
            }
            return visitor.Global.WrapClr(parameter);
        }
    }
}
