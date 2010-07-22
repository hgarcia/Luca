using System.Collections.Generic;

namespace Jint.Native
{
    public interface IGlobal
    {
        bool HasOption(Options options);

        JsArrayConstructor ArrayClass { get; }
        JsBooleanConstructor BooleanClass { get; }
        JsDateConstructor DateClass { get; }
        JsErrorConstructor ErrorClass { get; }
        JsErrorConstructor EvalErrorClass { get; }
        JsFunctionConstructor FunctionClass { get; }
        JsInstance IsNaN(JsInstance[] arguments);
        JsMathConstructor MathClass { get; }
        JsNumberConstructor NumberClass { get; }
        JsObjectConstructor ObjectClass { get; }
        JsInstance ParseFloat(JsInstance[] arguments);
        JsInstance ParseInt(JsInstance[] arguments);
        JsErrorConstructor RangeErrorClass { get; }
        JsErrorConstructor ReferenceErrorClass { get; }
        JsRegExpConstructor RegExpClass { get; }
        JsStringConstructor StringClass { get; }
        JsErrorConstructor SyntaxErrorClass { get; }
        JsErrorConstructor TypeErrorClass { get; }
        JsErrorConstructor UriErrorClass { get; }
        JsObject Wrap(object value);
        JsClr WrapClr(object value);

        JsInstance NaN { get; }

        IList<IExtensionRegister> Extensions { get; }
        Expressions.IJintVisitor Visitor { get; }
    }
}
