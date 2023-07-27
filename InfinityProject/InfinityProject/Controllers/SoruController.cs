using InfinityProject.Business.KategoriBL;
using InfinityProject.Business.SınavBL;
using InfinityProject.Business.SoruBL;
using InfinityProject.Business.SoruTipiBL;
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
    public class SoruController : Controller
    {
        SoruBL soruBL = new SoruBL();
        SoruTipiBL soruTipiBL = new SoruTipiBL();
        KategoriBL kategoriBL = new KategoriBL();
        public SoruController()
        {
        }

        public IActionResult Index(int id)
        {
            ViewBag.SinavId = id;
            return View(soruBL.GetSoruList(id));
        }
        public IActionResult SoruOlustur(int id)
        {
            SoruOlusturDTO soruOlusturDTO = new SoruOlusturDTO();
            soruOlusturDTO.KategoriList = kategoriBL.GetKategoriList();
            soruOlusturDTO.SoruTipiList = soruTipiBL.GetSoruTipiList();
            soruOlusturDTO.SinavId = id;

            return View(soruOlusturDTO);
        }
        [HttpPost]
        public IActionResult SoruOlustur(Soru soru)
        {
            soruBL.SoruEkle(soru);
            return RedirectToAction("Index", new { id = soru.SinavId });
        }
    }
}
