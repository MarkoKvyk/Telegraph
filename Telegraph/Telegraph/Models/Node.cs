using Kvyk.Telegraph.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kvyk.Telegraph.Models
{
    /// <summary>
    /// This object represents a DOM element node.
    /// <para/><see href="https://telegra.ph/api#Node">Telegraph documentation Node</see>
    /// <para/><see href="https://telegra.ph/api#NodeElement">Telegraph documentation NodeElement</see>
    /// </summary>
    [JsonConverter(typeof(NodeConverter))]
    public class Node
    {
        /// <summary>
        /// The value of the node.
        /// </summary>
        [JsonIgnore]
        public string Value { get; set; }

        /// <summary>
        /// Name of the DOM element. Available tags: a, aside, b, blockquote, br, code, em, figcaption, figure, h3, h4, hr, i, iframe, img, li, ol, p, pre, s, strong, u, ul, video.
        /// </summary>
        [JsonProperty("tag")]
        public string TagValue => Tag.ToString().ToLower();
        
        /// <summary>
        /// Value of the TagValue.
        /// </summary>
        [JsonIgnore]
        public TagEnum Tag { get; set; }

        /// <summary>
        /// Optional. Attributes of the DOM element. Key of object represents name of attribute, value represents value of attribute. Available attributes: href, src.
        /// </summary>
        [JsonProperty("attrs")]
        public List<TagAttribute> Artibutes { get; set; }

        /// <summary>
        /// Optional. List of child nodes for the DOM element.
        /// </summary>
        [JsonProperty("children")]
        public List<Node> Children { get; set; }
    }
}
