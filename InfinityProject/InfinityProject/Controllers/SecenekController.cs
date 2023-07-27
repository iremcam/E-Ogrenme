using InfinityProject.Business.SecenekBL;
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
    public class SecenekController:Controller
    {
        SecenekBL secenekBL = new SecenekBL();
        public IActionResult Index(int id)
        {
            ViewBag.SoruId = id;
            return View(secenekBL.GetSecenekList(id));
        }

        public IActionResult SecenekOlustur(int id)
        {
            SecenekOlusturDTO secenekOlusturDTO = new SecenekOlusturDTO();
            
            secenekOlusturDTO.SoruId = id;

            return View(secenekOlusturDTO);
        }
        [HttpPost]
        public IActionResult SecenekOlustur(Secenek secenek)
        {
            secenekBL.SecenekEkle(secenek);
            return RedirectToAction("Index", new { id = secenek.SoruId });
        }
    }
}
