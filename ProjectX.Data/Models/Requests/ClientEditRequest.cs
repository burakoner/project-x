using Newtonsoft.Json;
using ProjectX.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectX.Data.Models.Requests
{
    public class ClientEditRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("tckn")]
        public string Identity { get; set; }

        [JsonProperty("ehliyet")]
        public EhliyetSinifi DrivingLisenceClass { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}