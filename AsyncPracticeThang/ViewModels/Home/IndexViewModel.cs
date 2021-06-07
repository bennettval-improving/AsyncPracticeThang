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
        public List<Seleucid> Seleucids { get; set; }
        public Teacher Teacher { get; set; }
        public List<Teacher> YourTeachers { get; set; }
    }
}
