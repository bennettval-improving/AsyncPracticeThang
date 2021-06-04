using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncPracticeThang.Models;

namespace AsyncPracticeThang.ViewModels.Home
{
    public class IndexViewModel
    {
        public int RandomNumber { get; set; }
        public string ChuckNorrisFact { get; set; }
        public SeleucidsResult Seleucids { get; set; }
    }
}
