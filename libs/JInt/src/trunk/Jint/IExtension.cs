using System;
using Jint.Native;

namespace Jint
{
    public interface IExtension
    {
        void ExtendTarget(JsConstructor objectToExtend);
        Type TypeName { get;}
    }
}