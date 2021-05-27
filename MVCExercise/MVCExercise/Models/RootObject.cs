using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExercise.Models
{
    public class RootObject
    {

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("total_pages")]
        public string TotalPages { get; set; }

        [JsonProperty("data")]
        public Color[] Data { get; set; }

        [JsonProperty("support")]
        public object Support { get; set; }
    }
}
