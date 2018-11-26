using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class System : Changeable
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

        private int type;

        [JsonProperty("type")]
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                //OnPropertyChanged("Type");
            }
        }

        private decimal message;

        [JsonProperty("message")]
        public decimal Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                //OnPropertyChanged("Message");
            }
        }

        private string country;

        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                //OnPropertyChanged("Country");
            }
        }

        private DateTime sunrise;

        [JsonProperty("sunrise")]
        [JsonIgnore]
        public DateTime Sunrise
        {
            get
            {
                return sunrise;
            }
            set
            {
                sunrise = value;
                //OnPropertyChanged("Sunrise");
            }
        }

        private DateTime sunset;

        [JsonProperty("sunset")]
        [JsonIgnore]
        public DateTime Sunset
        {
            get
            {
                return sunset;
            }
            set
            {
                sunset = value;
                //OnPropertyChanged("Sunset");
            }
        }
    }
}
