using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetPageList : AccessTokenRequest
    {
        /// <summary>
        /// Sequential number of the first page to be returned.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int Offset { get; set; }

        /// <summary>
        /// Limits the number of pages to be retrieved.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int Limit { get; set; }
    }
}
