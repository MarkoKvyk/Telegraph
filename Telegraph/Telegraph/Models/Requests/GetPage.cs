using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetPage
    {
        /// <summary>
        /// Required. Path to the Telegraph page (in the format Title-12-31, i.e. everything that comes after http://telegra.ph/).
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// If true, content field will be returned in Page object.
        /// </summary>
        [JsonProperty("return_content")]
        public bool ReturnContent { get; set; } = true;
    }
}
