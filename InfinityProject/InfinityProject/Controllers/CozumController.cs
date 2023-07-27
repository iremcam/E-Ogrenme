using InfinityProject.Business.CozumBL;
using InfinityProject.Business.KategoriBL;
using InfinityProject.Business.KullaniciSinavBL;
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
    public class CozumController : Controller
    {
        SoruBL soruBL = new SoruBL();
        CozumBL cozumBL = new CozumBL();
        KullaniciSinavBL kullaniciSinavBL = new KullaniciSinavBL();
        public CozumController()
        {
        }

        public IActionResult Index(int id)
        {
            kullaniciSinavBL.SinavBaslamaZamaniGuncelle(id);

            string kId = User.Claims.Where(x => x.Type == "KullaniciId").Select(x => x.Value).SingleOrDefault();
            CozumDTO cozumDTO = soruBL.SınavSorusuGetir(id, Convert.ToInt32(kId));
            if (cozumDTO == null)
            {
                kullaniciSinavBL.SinavBitisZamaniGuncelle(id);
            }

            return View(cozumDTO);
        }

        [HttpPost]
        public IActionResult CozumKaydet(CozumCevapDTO cozum)
        {
            string kId = User.Claims.Where(x => x.Type == "KullaniciId").Select(x => x.Value).SingleOrDefault();
            Cozum cozum1 = new Cozum();
            cozum1.SecenekAciklama = cozum.SecenekAciklama;
            cozum1.SecenekId = cozum.SecenekId;
            cozum1.SinavId = cozum.SinavId;
            cozum1.SoruId = cozum.SoruId;
            cozum1.KullaniciId = Convert.ToInt32(kId);
            cozumBL.CozumEkle(cozum1);
            return RedirectToAction("Index", new { id = cozum.KullaniciSinavId });
        }
    }
}
