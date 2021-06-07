﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class GetAccountInfo : AccessTokenRequest
    {
        /// <summary>
        /// (Array of String"," default = [“short_name”","“author_name”","“author_url”])<para/>List of account fields to return. Available fields: short_name"," author_name"," author_url"," auth_url"," page_count.
        /// </summary>
        [JsonProperty("fields")]
        public List<string> Fields { get; set; } = new List<string>
        {
            "short_name",
            "author_name",
            "author_url",
            "auth_url",
            "page_count"
        };
    }
}