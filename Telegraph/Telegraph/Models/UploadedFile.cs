using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    internal class UploadedFile
    {
        [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
        public string Src { get; set; }
    }
}
