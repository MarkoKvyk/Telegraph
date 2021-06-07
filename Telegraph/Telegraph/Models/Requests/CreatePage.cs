using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class CreatePage : AccessTokenRequest
    {
        /// <summary>
        /// Required. Page title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Author name, displayed below the article's title.
        /// </summary>
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.
        /// </summary>
        [JsonProperty("author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Required. Content of the page. 
        /// </summary>
        [JsonProperty("content")]
        public List<Node> Content { get; set; }

        /// <summary>
        /// If true, a content field will be returned in the Page object.
        /// </summary>
        [JsonProperty("return_content")]
        public bool ReturnContent { get; set; } = true;
    }
}
