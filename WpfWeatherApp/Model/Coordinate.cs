using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Coordinate
    {
        [JsonProperty("lon")]
        public int Longitude { get; set; }

        [JsonProperty("lat")]
        public int Latitude { get; set; }
    }
}
