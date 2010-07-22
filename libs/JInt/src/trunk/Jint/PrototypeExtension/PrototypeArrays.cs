using System;
using System.Collections.Generic;
using System.Linq;
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
            Target.Prototype.DefineOwnProperty("toArray", Target.Global.FunctionClass.New<JsArray>(CloneImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("compact", Target.Global.FunctionClass.New<JsArray>(CompactImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("first", Target.Global.FunctionClass.New<JsArray>(FirstImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("last", Target.Global.FunctionClass.New<JsArray>(LastImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("flatten", Target.Global.FunctionClass.New<JsArray>(FlattenImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("indexOf", Target.Global.FunctionClass.New<JsArray>(IndexOfImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("intersect", Target.Global.FunctionClass.New<JsArray>(IntersectImpl), PropertyAttributes.DontEnum);
            Target.Prototype.DefineOwnProperty("lastIndexOf", Target.Global.FunctionClass.New<JsArray>(LastIndexOfImpl), PropertyAttributes.DontEnum);
                        
        }

        public JsInstance LastIndexOfImpl(JsArray target, JsInstance[] parameters)
        {
            var result = Target.Global.NumberClass.New(-1);
            if (parameters.Length == 0 || target.Length == 0) return result;
            var valueToFind = parameters[0];
            var offset = parameters.Length == 2 && parameters[1].GetType() == typeof(JsNumber) ? 
                Convert.ToInt32(parameters[1].Value.ToString()) : 0;
            var limit = target.Length - 1 - offset;
            for (var i = limit; i >- 0 ; i--)
            {
                if (areEqual(target[i.ToString()],valueToFind))
                {
                    return Target.Global.NumberClass.New(i);    
                }
            }
            return result;
        }

        public JsInstance IntersectImpl(JsArray target, JsInstance[] parameters)
        {
            if (parameters.Length == 0 || parameters[0].GetType() != typeof(JsArray)) return target;
            var paramArray = (JsArray)parameters[0];
            var shortArray = target.Length < paramArray.Length ? target : paramArray;
            var longArray = target.Length > paramArray.Length ? target : paramArray;
            var intersected = Target.Global.ArrayClass.New();
            foreach (var item in shortArray)
            {
                foreach (var pair in findItem(longArray,item.Value))
                {
                    intersected[intersected.Length.ToString()] = pair.Value;
                }
            }
            return intersected;
        }

        private IEnumerable<KeyValuePair<string, JsInstance>> 
            findItem(IEnumerable<KeyValuePair<string, JsInstance>> target, JsInstance valueToFind)
        {
            return target.Where(item =>
                                areEqual(item.Value, valueToFind));
        }

        private bool areEqual(JsInstance itemValue, JsInstance valueToFind)
        {
            return itemValue.GetType() == valueToFind.GetType() &&
                   itemValue.Value.ToString() == valueToFind.Value.ToString();
        }

        public JsInstance IndexOfImpl(JsArray target, JsInstance[] parameters)
        {
            var result = Target.Global.NumberClass.New(-1);
            if (parameters.Length == 0) return result;
            var valueToFind = parameters[0];
            foreach (var item in findItem(target,valueToFind))
            {
                return Target.Global.NumberClass.New(Convert.ToDouble(item.Key));
            }
            return result;
        }

        private void flattenTargetIntoResult(JsArray target, JsArray result)
        {
            for (var i = 0; i < target.Length; i++)
            {
                if (target[i.ToString()].GetType() != typeof(JsArray))
                {
                    result[result.Length.ToString()] = target[i.ToString()];
                }
                else
                {
                    flattenTargetIntoResult((JsArray)target[i.ToString()], result);
                }
            }
        }

        public JsInstance FlattenImpl(JsArray target, JsInstance[] parameters)
        {
            var result = Target.Global.ArrayClass.New();
            flattenTargetIntoResult(target, result);
            return result;
        }

        public JsInstance LastImpl(JsArray target, JsInstance[] parameters)
        {
            return target[(target.Length-1).ToString()];
        }

        public JsInstance FirstImpl(JsArray target, JsInstance[] parameters)
        {
            return target[0.ToString()];
        }

        public JsInstance CompactImpl(JsArray target, JsInstance[] parameters)
        {
            var result = Target.Global.ArrayClass.New();
            for (var i = 0; i < target.Length; i++)
            {
                if (target[i.ToString()] != JsUndefined.Instance && target[i.ToString()] != JsNull.instance)
                    result[result.Length.ToString()] = target[i.ToString()]; 
            }
            return result;
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
