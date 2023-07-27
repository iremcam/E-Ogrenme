using InfinityProject.Business.KategoriBL;
using InfinityProject.Models;
using InfinityProject.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        KategoriBL kategoriBL = new KategoriBL();
        public IActionResult Index()
        {
            return View(kategoriBL.GetKategoriList());
        }
        public IActionResult KategoriOlustur()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult KategoriOlustur(Kategori kategori)
        {
            kategoriBL.KategoriEkle(kategori);
            return RedirectToAction("Index");
        }
    }
}
