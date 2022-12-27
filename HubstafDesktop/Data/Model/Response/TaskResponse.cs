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
        private int id;
        private string name;
        private string description;
        private string status;
        private string timeNeeded;
        private object doneDate;
        private int assignerId;
        private int assigneeId;
        private int projectId;
        private DateTime createdAt;
        private DateTime updatedAt;

        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }

        [JsonProperty("description")]
        public string Description { get => description; set => description = value; }

        [JsonProperty("status")]
        public string Status { get => status; set => status = value; }

        [JsonProperty("time_needed")]
        public string TimeNeeded { get => timeNeeded; set => timeNeeded = value; }

        [JsonProperty("done_date")]
        public object DoneDate { get => doneDate; set => doneDate = value; }

        [JsonProperty("assigner_id")]
        public int AssignerId { get => assignerId; set => assignerId = value; }

        [JsonProperty("assignee_id")]
        public int AssigneeId { get => assigneeId; set => assigneeId = value; }

        [JsonProperty("project_id")]
        public int ProjectId { get => projectId; set => projectId = value; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
