using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    /// <summary>
    /// Attributes of the DOM element. Key of object represents name of attribute, value represents value of attribute. Available attributes: href, src.
    /// </summary>
    public class TagAttribute
    {
        [JsonProperty("name")]
        public string NameValue => Name.ToString().ToLower();

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonIgnore]
        public TagAttributeNameEnum Name { get; set; }
    }
}
