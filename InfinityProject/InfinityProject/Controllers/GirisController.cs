using InfinityProject.Business.KullaniciBL;
using InfinityProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InfinityProject.Controllers
{
    public class AccountController : Controller
    {
        KullaniciBL kullaniciBL = new KullaniciBL();
        public AccountController()
        {
        }

        public IActionResult Login(bool hatali = false)
        {
            if (hatali)
            {
                ViewBag.GirisHata = "Kullanıcı Adı ve ya Şifre Hatalı!";
            }
            return View();
        }

        public async Task<IActionResult> Giris(Kullanici kullanici)
        {
            kullanici = kullaniciBL.KullaniciKontrol(kullanici);
            if (kullanici != null)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

                identity.AddClaim(new Claim(ClaimTypes.Name, kullanici.KullaniciAdi));
                identity.AddClaim(new Claim("KullaniciId", kullanici.Id.ToString()));
                identity.AddClaim(new Claim("AuthMenu", kullanici.KullaniciTip.KullaniciTipAdi));



                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", new { hatali = true });
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account", null);
        }
    }
}
