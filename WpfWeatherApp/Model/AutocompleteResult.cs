using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfWeatherApp.ViewModel;

namespace WpfWeatherApp.Model
{
    public class AutocompleteResult
    {
        [JsonProperty("predictions")]
        public ObservableCollection<Prediction> Predictions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
