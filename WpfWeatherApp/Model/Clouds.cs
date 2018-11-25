using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Clouds : Changeable
    {
        [JsonProperty("all")]
        public int All
        {
            get
            {
                return All;
            }
            set
            {
                All = value; OnPropertyChanged("All");
            }
        }
    }
}
