﻿using Newtonsoft.Json;
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

        #region fck fck
        //private int id;
        //private string name;
        //private string description;
        //private string timespan;
        //private int organizationId;
        //private DateTime createdAt;
        //private DateTime updatedAt;

        //[JsonProperty("id")]
        //public int Id { get => id; set => id = value; }

        //[JsonProperty("name")]
        //public string Name { get => name; set => name = value; }

        //[JsonProperty("description")]
        //public string Description { get => description; set => description = value; }

        //[JsonProperty("timespan")]
        //public string Timespan { get => timespan; set => timespan = value; }

        //[JsonProperty("organization_id")]
        //public int OrganizationId { get => organizationId; set => organizationId = value; }

        //[JsonProperty("created_at")]
        //public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        //[JsonProperty("updated_at")]
        //public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        #endregion
    }
}