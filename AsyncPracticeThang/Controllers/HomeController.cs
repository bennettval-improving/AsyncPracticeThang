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
        private readonly HomeData _homeData;

        public HomeController(ILogger<HomeController> logger, HomeData homeData)
        {
            _logger = logger;
            _homeData = homeData;
        }

        public async Task<IActionResult> Index()
        {
            var randomNumber = await _homeData.GetRandomNumber();
            var chuckNorrisFact = await _homeData.GetChuckNorrisFact();
            var seleucids = await _homeData.GetSeleucids();
            var viewModel = new IndexViewModel 
            { 
                RandomNumber = randomNumber,
                ChuckNorrisFact = chuckNorrisFact,
                Seleucids = seleucids
            };
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

        
    }
}
