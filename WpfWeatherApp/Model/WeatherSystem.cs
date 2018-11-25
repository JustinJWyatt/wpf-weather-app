using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class WeatherSystem : Changeable
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

        [JsonProperty("type")]
        public int Type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
                OnPropertyChanged("Type");
            }
        }

        [JsonProperty("message")]
        public decimal Message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
                OnPropertyChanged("Message");
            }
        }

        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return Country;
            }
            set
            {
                Country = value;
                OnPropertyChanged("Country");
            }
        }

        [JsonProperty("sunrise")]
        public DateTime Sunrise
        {
            get
            {
                return Sunrise;
            }
            set
            {
                Sunrise = value;
                OnPropertyChanged("Sunrise");
            }
        }

        [JsonProperty("sunset")]
        public DateTime Sunset
        {
            get
            {
                return Sunset;
            }
            set
            {
                Sunset = value;
                OnPropertyChanged("Sunset");
            }
        }
    }
}
