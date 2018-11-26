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
        private float temperature;

        [JsonProperty("temp")]
        public float Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
                //OnPropertyChanged("Temperautre");
            }
        }

        private int pressure;

        [JsonProperty("pressure")]
        public int Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
                //OnPropertyChanged("Pressure");
            }
        }

        private int humidity;

        [JsonProperty("humidity")]
        public int Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                humidity = value;
                //OnPropertyChanged("Humidity");
            }
        }

        private float minTemperature;

        [JsonProperty("temp_min")]
        public float MinTemperature
        {
            get
            {
                return minTemperature;
            }
            set
            {
                minTemperature = value;
                //OnPropertyChanged("MinTemperature");
            }
        }

        private float maxTemperature;

        [JsonProperty("temp_max")]
        public float MaxTemperature
        {
            get
            {
                return maxTemperature;
            }
            set
            {
                maxTemperature = value;
                //OnPropertyChanged("MaxTemperature");
            }
        }
    }
}
