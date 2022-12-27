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
        // private int id;
        // private string name;
        // private string email;
        // private string username;
        //// private DateTime email_verified_at;
        // private DateTime created_at;
        // private DateTime updated_at;

        // [JsonProperty("id")]
        // public int Id { get => id; set => id = value; }

        // [JsonProperty("name")]
        // public string Name { get => name; set => name = value; }

        // [JsonProperty("email")]
        // public string Email { get => email; set => email = value; }

        // [JsonProperty("username")]
        // public string Username { get => username; set => username = value; }

        //// [JsonProperty("email_verified_at")]
        //// public DateTime Email_verified_at { get => email_verified_at; set => email_verified_at = value; }

        // [JsonProperty("created_at")]
        // public DateTime Created_at { get => created_at; set => created_at = value; }

        // [JsonProperty("updated_at")]
        // public DateTime Updated_at { get => updated_at; set => updated_at = value; }

        // [JsonProperty("auth-token")]
        // public string authtoken { get; set; }
    }
}
