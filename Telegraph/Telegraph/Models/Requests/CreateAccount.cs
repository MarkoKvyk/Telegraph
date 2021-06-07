using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class CreateAccount
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

    }
}
