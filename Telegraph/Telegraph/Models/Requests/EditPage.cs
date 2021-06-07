using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class EditPage : CreatePage
    {
        /// <summary>
        /// Required. Path to the page.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
