using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetViews
    {
        /// <summary>
        /// Required. Path to the Telegraph page (in the format Title-12-31, where 12 is the month and 31 the day the article was first published).
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Required if month is passed. If passed, the number of page views for the requested year will be returned.
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }

        /// <summary>
        /// Required if day is passed. If passed, the number of page views for the requested month will be returned.
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public int? Month { get; set; }

        /// <summary>
        /// Required if hour is passed. If passed, the number of page views for the requested day will be returned.
        /// </summary>
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public int? Day { get; set; }

        /// <summary>
        /// If passed, the number of page views for the requested hour will be returned.
        /// </summary>
        [JsonProperty("hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hour { get; set; }
    }
}
