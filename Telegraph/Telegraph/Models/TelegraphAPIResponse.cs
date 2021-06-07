using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models
{
    internal class TelegraphAPIResponse<T>
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
