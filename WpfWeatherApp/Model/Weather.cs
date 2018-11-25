using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class Weather : Changeable
    {
        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
                OnPropertyChanged("Id");
            }
        }

        [JsonProperty("main")]
        public string Main
        {
            get
            {
                return Main;
            }
            set
            {
                Main = value;
                OnPropertyChanged("Main");
            }
        }

        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
                OnPropertyChanged("Description");
            }
        }

        [JsonProperty("icon")]
        public string Icon
        {
            get
            {
                return Icon;
            }
            set
            {
                Icon = value;
                OnPropertyChanged("Icon");
            }
        }
    }
}
