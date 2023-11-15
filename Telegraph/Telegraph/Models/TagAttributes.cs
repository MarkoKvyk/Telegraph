using Newtonsoft.Json;

namespace Telegraph.Models;

/// <summary>
/// Attributes of the DOM element. Key of object represents name of attribute, value represents value of attribute. Available attributes: href, src.
/// </summary>
public class TagAttributes
{
	[JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
	public string Href { get; set; }

	[JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
	public string Src { get; set; }
}