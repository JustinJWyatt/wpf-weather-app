using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Main
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("temp_min")]
        public float MinTemperature { get; set; }

        [JsonProperty("temp_max")]
        public float MaxTemperature { get; set; }
    }
}
