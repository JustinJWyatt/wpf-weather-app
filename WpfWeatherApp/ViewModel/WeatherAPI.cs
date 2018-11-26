using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WpfWeatherApp.Model;

namespace WpfWeatherApp.ViewModel
{
    public class WeatherAPI
    {
        public const string API_KEY = "727c7bf5d7906d46bd35ea902a53bf1f";
        public const string BASE_URL = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}";
        public const string BASE_URL_AUTOCOMPLETE = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&types=(cities)&key={1}";
        public const string AUTO_COMPLETE_API_KEY = "AIzaSyCYgmDSVCgLvCzqe-UgMUShnMdF4zcVqRk";

        public static async Task<WeatherResult> GetWeatherInformationAsync(string city)
        {
            var result = new WeatherResult();

            using (HttpClient client = new HttpClient())
            {
                var query = string.Format(BASE_URL, city, API_KEY);

                var response = await client.GetAsync(query);

                var json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<WeatherResult>(json);
            }

            return result;
        }

        public static async Task<AutocompleteResult> GetAutoCompleteAsync(string query)
        {
            var result = new AutocompleteResult();

            var url = string.Format(BASE_URL_AUTOCOMPLETE, query, AUTO_COMPLETE_API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AutocompleteResult>(json);
            }

            return result;
        }
    }
}
