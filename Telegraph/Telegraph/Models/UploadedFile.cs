using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    internal class UploadedFile
    {
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
