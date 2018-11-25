using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWeatherApp.Model;

namespace WpfWeatherApp.ViewModel
{
    public class WeatherViewModel
    {
        public WeatherResult Weather { get; set; }

        public string Query
        {
            get
            {
                return Query;
            }
            set
            {
                Query = value;
            }
        }
    }
}
