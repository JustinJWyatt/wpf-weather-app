using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfWeatherApp.Model;

namespace WpfWeatherApp.ViewModel
{
    public class WeatherAPI
    {
        public const string API_KEY = "727c7bf5d7906d46bd35ea902a53bf1f";
        public const string BASE_URL = "api.openweathermap.org/data/2.5/weather?q={0},{1}&appid={2}";

        public static async Task<WeatherResult> GetWeatherInformationAsync(string city, string countryCode)
        {
            var result = new WeatherResult();

            using (HttpClient client = new HttpClient())
            {
                var query = string.Format(BASE_URL, city, countryCode, API_KEY);

                var response = await client.GetAsync(query);

                var json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<WeatherResult>(json);
            }

            return result;
        }
    }
}
