using Kvyk.Telegraph.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

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
            var node = new Node();

            var token = JToken.Load(reader);

            if (token.Type == JTokenType.Object)
            {
                var type = typeof(Node);

                foreach (var item in type.GetProperties())
                {
                    var name = item.Name;
                    var attrs = item.GetCustomAttributes(false);

                    if (!attrs.Where(v => v.GetType() == typeof(JsonIgnoreAttribute)).Any())
                    {
                        foreach (JsonPropertyAttribute attr in attrs.Where(v => v.GetType() == typeof(JsonPropertyAttribute)))
                        {
                            name = attr.PropertyName;
                        }
                    }
                    else
                    {
                        continue;
                    }

                    item.SetValue(node, token[name]?.ToObject(item.PropertyType));
                }

                return node;
            }
            else
            {
                node.Value = token.ToString();
                return node;
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
                writer.WriteStartObject();

                var type = value.GetType();

                foreach (var item in type.GetProperties().Where(v => v.Name != nameof(Node.Children)))
                {
                    var name = item.Name;
                    var attrs = item.GetCustomAttributes(false);

                    if (!attrs.Where(v => v.GetType() == typeof(JsonIgnoreAttribute)).Any())
                    {
                        foreach (JsonPropertyAttribute attr in attrs.Where(v => v.GetType() == typeof(JsonPropertyAttribute)))
                        {
                            name = attr.PropertyName;
                        }
                        writer.WritePropertyName(name);
                        serializer.Serialize(writer, item.GetValue(value));
                    }
                }

                var childrenProp = type.GetProperties().FirstOrDefault(v => v.Name == nameof(Node.Children));
                var clildrenName = childrenProp.Name;

                var childrenPropAtrs = childrenProp.GetCustomAttributes(false);
                foreach (JsonPropertyAttribute attr in childrenPropAtrs.Where(v => v.GetType() == typeof(JsonPropertyAttribute)))
                {
                    clildrenName = attr.PropertyName;
                }

                writer.WritePropertyName(clildrenName);
                serializer.Serialize(writer, childrenProp.GetValue(value));

                writer.WriteEndObject();
            }
        }
    }
}
