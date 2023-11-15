using Newtonsoft.Json;

namespace Telegraph.Models;

/// <summary>
/// This object represents the number of page views for a Telegraph article.
/// <a href="https://telegra.ph/api#PageViews">Telegraph documentation</a>
/// </summary>
public class PageViews
{
	/// <summary>
	/// Number of page views for the target page.
	/// </summary>
	[JsonProperty("views", NullValueHandling = NullValueHandling.Ignore)]
	public int Views { get; set; }
}