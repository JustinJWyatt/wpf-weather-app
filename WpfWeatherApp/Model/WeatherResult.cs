using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WpfWeatherApp.Model
{
    public class WeatherResult : Changeable
    {
        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
                OnPropertyChanged("Id");
            }
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged("Name");
            }
        }

        [JsonProperty("dt")]
        public DateTime Time
        {
            get
            {
                return Time;
            }
            set
            {
                Time = value;
                OnPropertyChanged("Time");
            }
        }

        [JsonProperty("coord")]
        public Coordinate Coordinate
        {
            get
            {
                return Coordinate;
            }
            set
            {
                Coordinate = value;
                OnPropertyChanged("Coordinate");
            }
        }

        [JsonProperty("weather")]
        public List<Weather> Weather
        {
            get
            {
                return Weather;
            }
            set
            {
                Weather = value;
                OnPropertyChanged("Weather");
            }
        }

        [JsonProperty("base")]
        public string Base
        {
            get
            {
                return Base;
            }
            set
            {
                Base = value;
                OnPropertyChanged("Base");
            }
        }

        [JsonProperty("main")]
        public Main Main
        {
            get
            {
                return Main;
            }
            set
            {
                Main = value;
                OnPropertyChanged("Main");
            }
        }

        [JsonProperty("visibility")]
        public int Visibility
        {
            get
            {
                return Visibility;
            }
            set
            {
                Visibility = value;
                OnPropertyChanged("Visibility");
            }
        }

        [JsonProperty("wind")]
        public Wind Wind
        {
            get
            {
                return Wind;
            }
            set
            {
                Wind = value;
                OnPropertyChanged("Wind");
            }
        }

        [JsonProperty("clouds")]
        public Clouds Clouds
        {
            get
            {
                return Clouds;
            }
            set
            {
                Clouds = value;
                OnPropertyChanged("Clouds");
            }
        }

        [JsonProperty("sys")]
        public WeatherSystem WeatherSystem
        {
            get
            {
                return WeatherSystem;
            }
            set
            {
                WeatherSystem = value;
                OnPropertyChanged("WeatherSystem");
            }
        }
    }
}
