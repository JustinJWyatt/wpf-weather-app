using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WpfWeatherApp.Model
{
    public class WeatherResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public int Name { get; set; }

        [JsonProperty("dt")]
        public DateTime Time { get; set; }

        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("sys")]
        public WeatherSystem WeatherSystem { get; set; }

    }
}
