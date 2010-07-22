using System;
using Jint.Expressions;
using System.Reflection;

namespace Jint.Native
{
    /// <summary>
    /// Wraps a delegate which returns a value (a getter)
    /// </summary>
    [Serializable]
    public class ClrImplDefinition<T> : JsFunction
        where T : JsInstance
    {
        readonly Delegate _impl;
        private readonly int _length;
        readonly bool _hasParameters;

        private ClrImplDefinition(bool hasParameters)
        {
            _hasParameters = hasParameters;
        }

        public ClrImplDefinition(Func<T, JsInstance[], JsInstance> impl)
            : this(impl, -1)
        {
        }

        public ClrImplDefinition(Func<T, JsInstance[], JsInstance> impl, int length)
            : this(true)
        {
            _impl = impl;
            _length = length;
        }

        public ClrImplDefinition(Func<T, JsInstance> impl)
            : this(impl, -1)
        {
        }

        public ClrImplDefinition(Func<T, JsInstance> impl, int length)
            : this(false)
        {
            this._impl = impl;
            this._length = length;
        }

        public override JsInstance Execute(IJintVisitor visitor, JsDictionaryObject that, JsInstance[] parameters)
        {
            try
            {
                JsInstance result;
                if (_hasParameters)
                    result = _impl.DynamicInvoke(new object[] { that, parameters }) as JsInstance;
                else
                    result = _impl.DynamicInvoke(new object[] { that }) as JsInstance;

                visitor.Return(result);
                return result;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
            catch (ArgumentException e)
            {
                var constructor = that.Prototype["constructor"] as JsFunction;
                throw new JsException(visitor.Global.TypeErrorClass.New("incompatible type: " + constructor == null ? "" : constructor.Name));
            }
            catch (Exception e)
            {
                if (e.InnerException is JsException)
                {
                    throw e.InnerException;
                }

                throw;
            }
        }

        public override int Length
        {
            get
            {
                if (_length == -1)
                    return base.Length;
                return _length;
            }
        }

        public override string ToString()
        {
            return String.Format("function {0}() { [native code] }", _impl.Method.Name);
        }

    }
}
