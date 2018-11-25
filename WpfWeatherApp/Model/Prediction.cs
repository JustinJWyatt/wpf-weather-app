using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class Prediction
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public List<MatchedSubstring> MatchedSubstrings { get; set; }
        public string PlaceId { get; set; }
        public string Reference { get; set; }
        public StructuredFormatting StructuredFormatting { get; set; }
        public List<Term> Terms { get; set; }
        public List<string> Types { get; set; }
    }
}
