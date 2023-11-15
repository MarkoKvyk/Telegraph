using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Telegraph.Models;

/// <summary>
/// This object represents a list of Telegraph articles belonging to an account. Most recently created articles first.
/// <a href="https://telegra.ph/api#PageList">Telegraph documentation</a>
/// </summary>
[JsonObject]
public class PageList : IEnumerable<Page>
{
	/// <summary>
	/// Total number of pages belonging to the target Telegraph account.
	/// </summary>
	[JsonProperty("total_count")]
	public int TotalCount { get; set; }

	/// <summary>
	/// Requested pages of the target Telegraph account.
	/// </summary>
	[JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
	public List<Page> Pages { get; set; }

	#region IEnumarable implementation

	public IEnumerator<Page> GetEnumerator()
	{
		return Pages.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	#endregion
}