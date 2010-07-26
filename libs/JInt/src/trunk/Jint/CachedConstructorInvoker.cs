using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Jint
{
    class CachedConstructorInvoker : IConstructorInvoker
    {
        readonly IMethodInvoker _methodInvoker;

        public CachedConstructorInvoker(IMethodInvoker methodInvoker)
        {
            _methodInvoker = methodInvoker;
        }

        readonly Dictionary<Type, Dictionary<string, ConstructorInfo>> _cache = new Dictionary<Type, Dictionary<string, ConstructorInfo>>();

        public string GetCacheKey(object[] parameters)
        {
            var sb = new StringBuilder();
            foreach (var obj in parameters)
            {
                sb.Append(obj.GetType().FullName).Append(';');
            }

            return sb.ToString();
        }

        public ConstructorInfo Invoke(Type type, object[] parameters)
        {
            ConstructorInfo constructorInfo = null;
            var key = GetCacheKey(parameters);

            // Static evaluation

            if (!_cache.ContainsKey(type))
            {
                _cache.Add(type, new Dictionary<string, ConstructorInfo>());
            }

            if (!_cache[type].ContainsKey(key))
            {
                var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

                var ms = constructors.Where(m => m.GetParameters().Length == parameters.Length).ToList();

                foreach (var m in
                    from m in ms
                    let pis = m.GetParameters()
                    where _methodInvoker.TryGetAppropriateParameters(parameters, pis, null)
                    select m)
                {
                    constructorInfo = m;
                    break;
                }

                if (constructorInfo != null)
                {
                    _cache[type].Add(key, constructorInfo);
                }
            }
            else
            {
                constructorInfo = _cache[type][key];
                _methodInvoker.TryGetAppropriateParameters(parameters, constructorInfo.GetParameters(), null);
            }

            return constructorInfo;
        }
    }
}
