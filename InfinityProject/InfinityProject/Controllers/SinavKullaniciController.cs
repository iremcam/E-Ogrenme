using InfinityProject.Business.KullaniciBL;
using InfinityProject.Business.KullaniciSinavBL;
using InfinityProject.Business.SınavBL;
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
    public class SinavKullaniciController: Controller
    {
        KullaniciSinavBL kullaniciSinavBL = new KullaniciSinavBL();
        KullaniciBL kullaniciBl = new KullaniciBL();
        SınavBL sinavBl = new SınavBL();

        public SinavKullaniciController()
        {
        }
        public IActionResult Index()
        {
            return View(kullaniciSinavBL.GetSinavKullaniciList());
        }

        public IActionResult KullaniciAta(int id)
        {
            KullaniciAtaDTO kullaniciAtaDTO = new KullaniciAtaDTO();
            kullaniciAtaDTO.Sinavs = sinavBl.GetSınavList();
            kullaniciAtaDTO.Kullanicis = kullaniciBl.GetKullaniciList();

            kullaniciAtaDTO.SinavId = id;

            return View(kullaniciAtaDTO);
        }
        [HttpPost]
        public IActionResult KullaniciAta(SinavKullanici sinavKullanici)
        {
            kullaniciSinavBL.KullaniciAta(sinavKullanici);
            return RedirectToAction("Index", new { id = sinavKullanici.SinavId });
        }
    }
}
