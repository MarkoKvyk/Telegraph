using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    /// <summary>
    /// Attributes of the DOM element. Key of object represents name of attribute, value represents value of attribute. Available attributes: href, src.
    /// </summary>
    public class TagAttributes
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
