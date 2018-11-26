using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class Weather : Changeable
    {
        private int id;

        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                //OnPropertyChanged("Id");
            }
        }

        private string main;

        [JsonProperty("main")]
        public string Main
        {
            get
            {
                return main;
            }
            set
            {
                main = value;
                //OnPropertyChanged("Main");
            }
        }

        private string description;

        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                //OnPropertyChanged("Description");
            }
        }

        private string icon;

        [JsonProperty("icon")]
        public string Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                //OnPropertyChanged("Icon");
            }
        }
    }
}
