using System;
using System.Collections.Generic;
using System.Text;

namespace Jint.Native
{
    public class JsPrototype : JsDictionaryObject
    {
        public JsPrototype(JsDictionaryObject parentPrototype)
        {
            Prototype = parentPrototype;
        }

        public const string TYPEOF = "prototype";

        public override string Class
        {
            get { return TYPEOF; }
        }

        public override object Value
        {
            get { return null; }
            set { }
        }
    }
}
