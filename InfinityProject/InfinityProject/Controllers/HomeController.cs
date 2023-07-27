using InfinityProject.Business.SınavBL;
using InfinityProject.Models;
using InfinityProject.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SınavBL sınavBL = new SınavBL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string kId = User.Claims.Where(x => x.Type == "KullaniciId").Select(x => x.Value).SingleOrDefault();
            List<SinavKullaniciDTO> sinavlar = sınavBL.KullaniciSinavlari(Convert.ToInt32(kId));
            return View(sinavlar);
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
