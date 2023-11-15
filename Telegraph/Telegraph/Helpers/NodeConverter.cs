using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Node = Telegraph.Models.Node;

namespace Telegraph.Helpers;

/// <summary>
///   Converter for <see cref="Node" />.
/// </summary>
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
				string name = item.Name;
				object[] attrs = item.GetCustomAttributes(false);

				if (!attrs.Any(v => v is JsonIgnoreAttribute))
				{
					foreach (JsonPropertyAttribute attr in attrs.Where(v => v is JsonPropertyAttribute))
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

		node.Value = token.ToString();
		return node;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		var node = (Node) value;

		if (node?.Value != null)
		{
			writer.WriteValue(node.Value);
		}
		else
		{
			writer.WriteStartObject();

			var type = value.GetType();

			foreach (var item in type.GetProperties().Where(v => v.Name != nameof(Node.Children)))
			{
				string name = item.Name;
				object[] attrs = item.GetCustomAttributes(false);

				if (!attrs.Any(v => v is JsonIgnoreAttribute))
				{
					foreach (JsonPropertyAttribute attr in attrs.Where(v => v is JsonPropertyAttribute))
					{
						name = attr.PropertyName;
					}

					writer.WritePropertyName(name);
					serializer.Serialize(writer, item.GetValue(value));
				}
			}

			var childrenProp = type.GetProperties().FirstOrDefault(v => v.Name == nameof(Node.Children));
			string clildrenName = childrenProp.Name;

			object[] childrenPropAtrs = childrenProp.GetCustomAttributes(false);
			foreach (JsonPropertyAttribute attr in childrenPropAtrs.Where(v => v is JsonPropertyAttribute))
			{
				clildrenName = attr.PropertyName;
			}

			writer.WritePropertyName(clildrenName);
			serializer.Serialize(writer, childrenProp.GetValue(value));

			writer.WriteEndObject();
		}
	}
}