using Kvyk.Telegraph.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Kvyk.Telegraph.Helpers
{
    internal class NodeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Node));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);

            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<Node>();
            }
            else
            {
                return new Node()
                {
                    Value = token.ToString()
                };
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var node = (Node)value;

            if (node.Value != null)
            {
                writer.WriteValue(node.Value);
            }
            else
            {
                serializer.Serialize(writer, node);
            }
        }
    }
}
