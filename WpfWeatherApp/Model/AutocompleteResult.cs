using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class AutocompleteResult
    {
        [JsonProperty("predictions")]
        public List<Prediction> Predictions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
