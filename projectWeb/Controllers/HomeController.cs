using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using project.api.ViewModels;
using projectWeb.Helper;
using projectWeb.Models;

namespace projectWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         WizeApi api =new WizeApi();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> test() {
            List<register> users = new List<register>();
            HttpClient client = api.intial();
            HttpResponseMessage res = await client.GetAsync("api/account");
            if (res.IsSuccessStatusCode) {

                var result = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<register>>(result);
            
            }

            return View(users);
        }
        public ActionResult signUp() {


            return View();
        }
    }
}
