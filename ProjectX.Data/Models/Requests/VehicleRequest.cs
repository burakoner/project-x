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
    public class VehicleRequest
    {
        [JsonProperty("marka")]
        public string Marka { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("yakitTuru")]
        public string YakitTuru { get; set; }

        [JsonProperty("yil")]
        public int Yil { get; set; }

        [JsonProperty("ehliyet")]
        public EhliyetSinifi DrivingLisenceClass { get; set; }

        [JsonProperty("note")]
        public string Not { get; set; }
    }
}

