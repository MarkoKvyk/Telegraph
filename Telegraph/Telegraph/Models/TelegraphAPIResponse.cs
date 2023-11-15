using Newtonsoft.Json;

namespace Telegraph.Models;

internal class TelegraphAPIResponse<T>
{
	[JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
	public bool Ok { get; set; }

	[JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
	public T Result { get; set; }

	[JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
	public string Error { get; set; }
}