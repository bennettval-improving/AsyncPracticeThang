using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public async Task<string> GetChuckNorrisFact()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/chucknorrisfact");
                var contentString = await result.Content.ReadAsStringAsync();
                var fact = JsonSerializer.Deserialize<ChuckNorrisFact>(contentString);
                return fact.Joke;
            }
        }

        public async Task<List<Seleucid>> GetSeleucids()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/seleucids");
                var contentString = await result.Content.ReadAsStringAsync();
                var seleucidsResult = JsonSerializer.Deserialize<SeleucidsResult>(contentString);
                return seleucidsResult.Seleucids;
            }
        }

        public async Task<Teacher> GetTeacherData()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/ateacher");
                var contentString = await result.Content.ReadAsStringAsync();

                using (var stringReader = new StringReader(contentString))
                {
                    var serializer = new XmlSerializer(typeof(Teacher));
                    var teacher = serializer.Deserialize(stringReader) as Teacher;
                    return teacher;
                }
            }
        }

        public async Task<List<Teacher>> GetYourTeachersData()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/yourteachers");
                var contentString = await result.Content.ReadAsStringAsync();

                using (var stringReader = new StringReader(contentString))
                {
                    var serializer = new XmlSerializer(typeof(List<Teacher>));
                    var teachers = serializer.Deserialize(stringReader) as List<Teacher>;
                    return teachers;
                }
            }
        }
    }
}
