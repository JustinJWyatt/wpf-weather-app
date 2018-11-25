using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Coordinate : Changeable
    {
        [JsonProperty("lon")]
        public int Longitude
        {
            get
            {
                return this.Longitude;
            }
            set
            {
                OnPropertyChanged("Longitutde");
            }
        }

        [JsonProperty("lat")]
        public int Latitude
        {
            get
            {
                return this.Latitude;
            }
            set
            {
                this.Latitude = value; OnPropertyChanged("Latitude");
            }
        }
    }
}
