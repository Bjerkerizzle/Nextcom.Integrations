using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nextcom.Integrations.ThirdParties.Tripletex
{
    public class AuthResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        //[JsonProperty("id")]
        //public string Id { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }
}
