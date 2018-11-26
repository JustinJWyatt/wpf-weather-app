using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Wind : Changeable
    {
        private float speed;

        [JsonProperty("speed")]
        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                //OnPropertyChanged("Speed");
            }
        }

        private int temperature;

        [JsonProperty("deg")]
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
                //OnPropertyChanged("Temperature");
            }
        }
    }
}
