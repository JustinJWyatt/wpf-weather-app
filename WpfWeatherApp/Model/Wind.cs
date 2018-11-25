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
        [JsonProperty("speed")]
        public float Speed
        {
            get
            {
                return Speed;
            }
            set
            {
                Speed = value;
                OnPropertyChanged("Speed");
            }
        }

        [JsonProperty("deg")]
        public int Temperature
        {
            get
            {
                return Temperature;
            }
            set
            {
                Temperature = value;
                OnPropertyChanged("Temperature");
            }
        }
    }
}
