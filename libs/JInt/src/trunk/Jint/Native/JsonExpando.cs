using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Jint.Native
{
    public class JsonExpando : DynamicObject
    {
        private readonly Dictionary<string, object> _members =
            new Dictionary<string, object>();

        public void SetMember(string name, object value)
        {
            var escapedName = GetEscapedName(name);
            if (!_members.ContainsKey(escapedName))
                _members.Add(escapedName, value);
            else
                _members[escapedName] = value;
        }

        public object GetMember(string name)
        {
            var escapedName = GetEscapedName(name);
            return _members.ContainsKey(escapedName) ? _members[escapedName] : null;
        }

        private static string GetEscapedName(string name)
        {
            return name.ToLower().Replace("_", "");
        }

        public override bool TrySetMember
            (SetMemberBinder binder, object value)
        {
            var escapedName = GetEscapedName(binder.Name);
            if (!_members.ContainsKey(escapedName))
                _members.Add(escapedName, value);
            else
                _members[escapedName] = value;

            return true;
        }
     
        public override bool TryGetMember
            (GetMemberBinder binder, out object result)
        {
            var escapedName = GetEscapedName(binder.Name);
            if (_members.ContainsKey(escapedName))
            {
                result = _members[escapedName];
                return true;
            }
            if (!base.TryGetMember(binder, out result))
            {
                result = string.Empty;
                return true;
            }
            return false;
        }
   
        public override bool TryInvokeMember
            (InvokeMemberBinder binder, object[] args, out object result)
        {
            var escapedName = GetEscapedName(binder.Name);
            if (_members.ContainsKey(escapedName)
                && _members[escapedName] is Delegate)
            {
                result = ((Delegate)_members[escapedName]).DynamicInvoke(args);
                return true;
            }
            return base.TryInvokeMember(binder, args, out result);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _members.Keys;
        }
    }
}