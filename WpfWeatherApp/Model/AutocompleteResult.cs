using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class AutocompleteResult
    {
        public List<Prediction> Predictions { get; set; }
        public string Status { get; set; }
    }
}
