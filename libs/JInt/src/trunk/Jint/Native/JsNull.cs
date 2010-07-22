using System;


namespace Jint.Native
{
    [Serializable]
    public class JsNull : JsObject
    {
        public static JsNull instance = new JsNull();

        public JsNull()
        {
            length = 0;
        }

        public const string TYPEOF = "object";

        public override string Class
        {
            get { return TYPEOF; }
        }

        public override bool ToBoolean()
        {
            return false;
        }

        public override double ToNumber()
        {
            return 0d;
        }

        public override string ToString()
        {
            return "null";
        }
    }
}
