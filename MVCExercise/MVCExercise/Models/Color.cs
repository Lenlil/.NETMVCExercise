using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExercise.Models
{
    public class Color
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("color")]
        public string ColorHex { get; set; }

        [JsonProperty("pantone_value")]
        public string PantoneValue { get; set; }        
    }
}
