using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetPageList : AccessTokenRequest
    {
        /// <summary>
        /// Sequential number of the first page to be returned.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Limits the number of pages to be retrieved.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
