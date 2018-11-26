using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class Clouds : Changeable
    {

        private int all;

        [JsonProperty("all")]
        public int All
        {
            get
            {
                return all;
            }
            set
            {
                all = value;
                //OnPropertyChanged("All");
            }
        }
    }
}
