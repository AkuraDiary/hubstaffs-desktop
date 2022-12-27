using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model.Response
{
    public class TaskResponse
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name;

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description;

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status;

        [JsonProperty("time_needed", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeNeeded;

        [JsonProperty("done_date", NullValueHandling = NullValueHandling.Ignore)]
        public object DoneDate;

        [JsonProperty("assigner_id", NullValueHandling = NullValueHandling.Ignore)]
        public int AssignerId;

        [JsonProperty("assignee_id", NullValueHandling = NullValueHandling.Ignore)]
        public int AssigneeId;

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId;

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt;

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt;

        
    }
}
