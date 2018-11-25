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
        public const string API_KEY = "";
        public const string BASE_URL = "";

        public async Task<WeatherResult> GetWeatherInformationAsync(string city)
        {
            var result = new WeatherResult();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(BASE_URL);

                var json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<WeatherResult>(json);
            }

            return result;
        }
    }
}
