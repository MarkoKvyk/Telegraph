﻿using Newtonsoft.Json;

namespace Telegraph.Models.Requests;

internal class EditPage : CreatePage
{
	/// <summary>
	/// Required. Path to the page.
	/// </summary>
	[JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
	public string Path { get; set; }
}