using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kvyk.Telegraph.Models
{
    /// <summary>
    /// This object represents a page on Telegraph.
    /// <para/><see href="https://telegra.ph/api#Page">Telegraph documentation</see>
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Path to the page.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// URL of the page.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Title of the page.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Description of the page.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Optional. Name of the author, displayed below the title.
        /// </summary>
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Optional. Profile link, opened when users click on the author's name below the title.  Can be any link, not necessarily to a Telegram profile or channel.
        /// </summary>
        [JsonProperty("author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Optional. Image URL of the page.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Optional. Content of the page.
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public List<Node> Content { get; set; }

        /// <summary>
        /// Number of page views for the page.
        /// </summary>
        [JsonProperty("views", NullValueHandling = NullValueHandling.Ignore)]
        public int Views { get; set; }

        /// <summary>
        /// Optional. Only returned if access_token passed. True, if the target Telegraph account can edit the page.
        /// </summary>
        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

    }
}
