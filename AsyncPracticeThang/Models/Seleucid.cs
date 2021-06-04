using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncPracticeThang.Models
{
    public class Seleucid
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("startReign")]
        public int StartReign { get; set; }
        [JsonPropertyName("endReign")]
        public int EndReign { get; set; }
        [JsonPropertyName("consorts")]
        public List<string> Consorts { get; set; }

    }
}
