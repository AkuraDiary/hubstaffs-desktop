using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model.Response
{
    public class GetProjectOfUserResponse
    {
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public UserAuthResponse User;

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectResponse> Project;
    }
}
