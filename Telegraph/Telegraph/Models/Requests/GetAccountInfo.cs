using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetAccountInfo : AccessTokenRequest
    {
        /// <summary>
        /// (Array of String"," default = [“short_name”","“author_name”","“author_url”])<para/>List of account fields to return. Available fields: short_name"," author_name"," author_url"," auth_url"," page_count.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; } = new List<string>
        {
            "short_name",
            "author_name",
            "author_url",
            "auth_url",
            "page_count"
        };
    }
}
