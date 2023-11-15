using Newtonsoft.Json;

namespace Telegraph.Models;

/// <summary>
/// This object represents a Telegraph account.
/// see <a href="https://telegra.ph/api#Account">API</a>
/// </summary>
public class Account
{
	/// <summary>
	/// Account name, helps users with several accounts remember which they are currently using. Displayed to the user above the "Edit/Publish" button on Telegra.ph, other users don't see this name.
	/// </summary>
	[JsonProperty("short_name")]
	public string ShortName { get; set; }

	/// <summary>
	/// Default author name used when creating new articles.
	/// </summary>
	[JsonProperty("author_name")]
	public string AuthorName { get; set; }

	/// <summary>
	/// Profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.
	/// </summary>
	[JsonProperty("author_url")]
	public string AuthorUrl { get; set; }

	/// <summary>
	/// Optional. Only returned by the CreateAccount and RevokeAccessToken method. Access token of the Telegraph account.
	/// </summary>
	[JsonProperty("access_token")]
	public string AccessToken { get; set; }

	/// <summary>
	/// Optional. URL to authorize a browser on telegra.ph and connect it to a Telegraph account. This URL is valid for only one use and for 5 minutes only.
	/// </summary>
	[JsonProperty("auth_url")]
	public string AuthUrl { get; set; }

	/// <summary>
	/// Optional. Number of pages belonging to the Telegraph account.
	/// </summary>
	[JsonProperty("page_count")]
	public int PageCount { get; set; }
}