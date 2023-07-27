using InfinityProject.Business.SınavBL;
using InfinityProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Controllers
{
    [Authorize]
    public class SinavController:Controller
    {
        SınavBL sinavBL = new SınavBL();
        public SinavController()
        {
        }

        public IActionResult Index()
        {
            return View(sinavBL.GetSınavList());
        }
        public IActionResult SinavOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SinavOlustur(Sinav sinav)
        {
            sinavBL.SinavEkle(sinav);
            return RedirectToAction("Index");
        }
    }
}
