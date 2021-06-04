using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncPracticeThang.Models
{
    public class SeleucidsResult
    {
        [JsonPropertyName("seleucids")]
        public List<Seleucid> Seleucids { get; set; }
    }
}
