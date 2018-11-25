using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WpfWeatherApp.Model
{
    public class StructuredFormatting
    {
        [JsonProperty("main_text")]
        public string MainText { get; set; }

        [JsonProperty("main_text_matched_substrings")]
        public List<MainTextMatchedSubstring> MainTextMatchedSubstrings { get; set; }

        [JsonProperty("secondary_text")]
        public string SecondaryText { get; set; }
    }
}
