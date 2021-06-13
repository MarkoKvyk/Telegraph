using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class EditAccountInfo : CreateAccount
    {
        /// <summary>
        /// Required. Access token of the Telegraph account.
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }
    }
}
