using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApp.Model
{
    public class StructuredFormatting
    {
        public string MainText { get; set; }
        public List<MainTextMatchedSubstring> MainTextMatchedSubstrings { get; set; }
        public string SecondaryText { get; set; }
    }
}
