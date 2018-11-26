using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WpfWeatherApp.Model
{
    public class WeatherResult : Changeable
    {
        private int id;

        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                //OnPropertyChanged("Id");
            }
        }

        private int cod;

        [JsonProperty("cod")]
        public int Cod
        {
            get
            {
                return cod;
            }
            set
            {
                cod = value;
                //OnPropertyChanged("Cod");
            }
        }

        private string name;

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                //OnPropertyChanged("Name");
            }
        }

        private DateTime time;

        [JsonProperty("dt")]
        [JsonIgnore]
        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                //OnPropertyChanged("Time");
            }
        }

        private Coordinate coordinate;

        [JsonProperty("coord")]
        public Coordinate Coordinate
        {
            get
            {
                return coordinate;
            }
            set
            {
                coordinate = value;
                //OnPropertyChanged("Coordinate");
            }
        }

        private List<Weather> weather;

        [JsonProperty("weather")]
        public List<Weather> Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
                //OnPropertyChanged("Weather");
            }
        }

        private string baseString;

        [JsonProperty("base")]
        public string Base
        {
            get
            {
                return baseString;
            }
            set
            {
                baseString = value;
                //OnPropertyChanged("Base");
            }
        }

        private Main main;

        [JsonProperty("main")]
        public Main Main
        {
            get
            {
                return main;
            }
            set
            {
                main = value;
                //OnPropertyChanged("Main");
            }
        }

        private int visibility;

        [JsonProperty("visibility")]
        public int Visibility
        {
            get
            {
                return visibility;
            }
            set
            {
                visibility = value;
                //OnPropertyChanged("Visibility");
            }
        }

        private Wind wind;

        [JsonProperty("wind")]
        public Wind Wind
        {
            get
            {
                return wind;
            }
            set
            {
                wind = value;
                //OnPropertyChanged("Wind");
            }
        }

        private Clouds clouds;

        [JsonProperty("clouds")]
        public Clouds Clouds
        {
            get
            {
                return clouds;
            }
            set
            {
                clouds = value;
                //OnPropertyChanged("Clouds");
            }
        }

        private System system;

        [JsonProperty("sys")]
        public System System
        {
            get
            {
                return system;
            }
            set
            {
                system = value;
                //OnPropertyChanged("System");
            }
        }
    }
}
