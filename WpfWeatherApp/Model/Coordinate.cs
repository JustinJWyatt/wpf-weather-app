using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class Coordinate : Changeable
    {
        private float longitude;

        [JsonProperty("lon")]
        public float Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;

                //OnPropertyChanged("Longitude");
            }
        }

        private float latitude;

        [JsonProperty("lat")]
        public float Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                //OnPropertyChanged("Latitude");
            }
        }
    }
}
