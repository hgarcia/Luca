using System;
using System.Text;
using Newtonsoft.Json;

namespace Luca.Core.Encoders
{
    public class Json : IEncoder
    {
        public string Encode(object toSerialize)
        {
            if (toSerialize.GetType() == typeof(JsonExpando)) return SerializeObject(toSerialize as JsonExpando);
            return JsonConvert.SerializeObject(toSerialize).Replace('\\', '^').Replace("^^", "/");
        }

        public string ContentType
        {
            get { return "application/json"; }
        }

        private string SerializeObject(JsonExpando objectToSerialize)
        {
            var serialized = new StringBuilder();

            var names = objectToSerialize.GetDynamicMemberNames();
            foreach (var name in names)
            {
                var value = objectToSerialize.GetMember(name);
                if (serialized.Length > 0) serialized.Append(",");
                if (serializeJsonExpando(value, serialized, name)) continue;
                if (serializeIEnumerable(value,serialized,name)) continue;
                if (serializeDefault(value, serialized, name)) continue; 
            }

            return "{" + serialized + "}";
        }

        private bool serializeIEnumerable(object value, StringBuilder serialized, string name)
        {
            if (value ==null || value.GetType().GetInterface("IEnumerable") == null) return false;
            serialized.AppendFormat("\"{0}\":{1}", name, JsonConvert.SerializeObject(value).Replace('\\','^').Replace("^^","/"));
            return true;
        }

        private bool serializeJsonExpando(object value, StringBuilder serialized, string name)
        {
            if (value == null || value.GetType() != typeof(JsonExpando)) return false;
            serialized.AppendFormat("\"{0}\":{1}", name, SerializeObject((JsonExpando)value));
            return true;
        }

        private bool serializeDefault(object value, StringBuilder serialized, string name)
        {
            if (value == null) return false;
            serialized.AppendFormat("\"{0}\":\"{1}\"",name,value.ToString().Replace('\\','^').Replace("^^","/"));
            return true;
        }
    }
}
