using Newtonsoft.Json;

namespace Telegraph.Models;

internal class UploadedFile
{
	[JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
	public string Src { get; set; }
}