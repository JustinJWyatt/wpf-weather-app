using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class Prediction
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("matched_substrings")]
        public List<MatchedSubstring> MatchedSubstrings { get; set; }
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [JsonProperty("structured_formatting")]
        public StructuredFormatting StructuredFormatting { get; set; }
        [JsonProperty("terms")]
        public List<Term> Terms { get; set; }
        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
