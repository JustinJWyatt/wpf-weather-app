using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWeatherApp.Model;

namespace WpfWeatherApp.ViewModel
{
    public class WeatherViewModel : Changeable
    {
        public WeatherResult Weather { get; set; }

        private AutocompleteResult citySearch;

        public AutocompleteResult CitySearch
        {
            get
            {
                return citySearch;
            }
            set
            {
                citySearch = value;
                OnPropertyChanged("CitySearch");
            }
        }

        private string query;

        public string Query
        {
            get
            {
                return query;
            }
            set
            {
                query = value;

                GetCities();
            }
        }

        public async void GetCities()
        {
            CitySearch = await WeatherAPI.GetAutoCompleteAsync(Query);
        }

    }
}
