using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model.Response
{
    public class UserAuthResponse
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name;

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email;

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username;

        [JsonProperty("email_verified_at", NullValueHandling = NullValueHandling.Ignore)]
        public object EmailVerifiedAt;

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt;

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt;

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Role Role;

        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public object Organization;

    }
}
