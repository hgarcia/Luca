using System;
using System.Collections.Generic;

namespace Jint
{
    public interface IExtensionRegister
    {
        IDictionary<Type, IExtension> Extensions { get; }
    }
}
