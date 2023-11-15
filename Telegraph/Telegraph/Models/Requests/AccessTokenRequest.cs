using Newtonsoft.Json;

namespace Telegraph.Models.Requests;

internal class AccessTokenRequest
{
	/// <summary>
	/// Required. Access token of the Telegraph account.
	/// </summary>
	[JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
	public string AccessToken { get; set; }
}