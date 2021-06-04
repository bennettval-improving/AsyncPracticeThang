using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncPracticeThang.Models
{
    public class HomeData
    {
        public async Task<int> GetRandomNumber()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/generatearandomnumber");
                var contentString =  await result.Content.ReadAsStringAsync();
                return int.Parse(contentString);
            }
        }
    }
}
