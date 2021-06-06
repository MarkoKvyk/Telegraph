using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
