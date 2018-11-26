using WpfWeatherApp.Model;
using WpfWeatherApp.ViewModel.Commands;

namespace WpfWeatherApp.ViewModel
{
    public class WeatherViewModel : Changeable
    {
        private WeatherResult result;

        public WeatherResult Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

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

        private Prediction selectedResult;

        public Prediction SelectedResult
        {
            get
            {
                return selectedResult;
            }
            set
            {
                selectedResult = value;

                GetWeather();
            }
        }

        public RefreshCommand RefreshCommand { get; set; }

        public WeatherViewModel()
        {
            RefreshCommand = new RefreshCommand(this);
        }

        private async void GetCities()
        {
            CitySearch = await WeatherAPI.GetAutoCompleteAsync(Query);
        }

        public async void GetWeather()
        {
            var city = SelectedResult.Description.Replace(" ", string.Empty);

            Result = await WeatherAPI.GetWeatherInformationAsync(city);
        }
    }
}
