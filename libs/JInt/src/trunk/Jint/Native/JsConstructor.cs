using System;
using System.Linq;

namespace Jint.Native
{
    [Serializable]
    public abstract class JsConstructor : JsFunction
    {
        public IGlobal Global { get; set; }

        public JsConstructor(IGlobal global)
        {
            Global = global;
            if (global.ObjectClass != null)
                Prototype = global.ObjectClass.New(this);
        }

        public abstract void InitPrototype(IGlobal global);
        

        public void Extend<TJsInstance>()
        {
            foreach (var register in
                Global.Extensions.Where(register => register.Extensions.ContainsKey(typeof(TJsInstance))))
            {
                register.Extensions[typeof(TJsInstance)].ExtendTarget(this);
            }
        }
    }
}
