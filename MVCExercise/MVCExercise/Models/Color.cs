using Newtonsoft.Json;

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
