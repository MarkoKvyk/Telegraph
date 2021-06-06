using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    /// <summary>
    /// This object represents the number of page views for a Telegraph article.
    /// <para/><see href="https://telegra.ph/api#PageViews">Telegraph documentation</see>
    /// </summary>
    public class PageViews
    {
        /// <summary>
        /// Number of page views for the target page.
        /// </summary>
        [JsonProperty("views")]
        public int Views { get; set; }
    }
}
