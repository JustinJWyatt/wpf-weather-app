using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Main : Changeable
    {
        [JsonProperty("temp")]
        public float Temperature
        {
            get
            {
                return this.Temperature;
            }
            set
            {
                Temperature = value;
                OnPropertyChanged("Temperautre");
            }
        }

        [JsonProperty("pressure")]
        public int Pressure
        {
            get
            {
                return Pressure;
            }
            set
            {
                Pressure = value;
                OnPropertyChanged("Pressure");
            }
        }

        [JsonProperty("humidity")]
        public int Humidity
        {
            get
            {
                return Humidity;
            }
            set
            {
                Humidity = value;
                OnPropertyChanged("Humidity");
            }
        }

        [JsonProperty("temp_min")]
        public float MinTemperature
        {
            get
            {
                return MinTemperature;
            }
            set
            {
                MinTemperature = value;
                OnPropertyChanged("MinTemperature");
            }
        }

        [JsonProperty("temp_max")]
        public float MaxTemperature
        {
            get
            {
                return MaxTemperature;
            }
            set
            {
                MaxTemperature = value;
                OnPropertyChanged("MaxTemperature");
            }
        }
    }
}
