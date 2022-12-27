using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model.Response
{
    public class ProjectResponse
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name;

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description;

        [JsonProperty("timespan", NullValueHandling = NullValueHandling.Ignore)]
        public string Timespan;

        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public int OrganizationId;

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt;

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt;

        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskResponse> Tasks;

        
    }
}
