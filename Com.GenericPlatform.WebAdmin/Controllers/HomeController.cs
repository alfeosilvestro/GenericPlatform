using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Com.GenericPlatform.WebAdmin.Models;
using Com.GenericPlatform.Services.Code;

namespace Com.GenericPlatform.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICodesService svs;

        public HomeController(ICodesService svs)
        {
            this.svs = svs;
        }

        public async Task<IActionResult> Index()
        {
            var result = await svs.GetCodesByPage("", 1);

            return View(result);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
