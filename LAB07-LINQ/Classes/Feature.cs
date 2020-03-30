using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LAB07_LINQ.Classes
{
    public class Feature
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }
        [JsonProperty("properties")]
        public Properties properties { get; set; }
    }
}
