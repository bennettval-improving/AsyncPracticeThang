using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AsyncPracticeThang.Models;
using AsyncPracticeThang.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AsyncPracticeThang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var randomNumber = await GetRandomNumber();
            var viewModel = new IndexViewModel { RandomNumber = randomNumber };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<string> GetRandomNumber()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://seriouslyfundata.azurewebsites.net/api/generatearandomnumber");
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
