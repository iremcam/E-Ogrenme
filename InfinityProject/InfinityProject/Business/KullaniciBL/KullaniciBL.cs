using InfinityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.KullaniciBL
{
    public class KullaniciBL
    {
        InfinityContext Context = new InfinityContext();
        public List<Kullanici> GetKullaniciList()
        {
            List<Kullanici> kullaniciList = Context.Kullanici.ToList();

            return kullaniciList;
        }
        public Kullanici KullaniciKontrol(Kullanici kullanici)
        {
            kullanici = Context.Kullanici.FirstOrDefault(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre);
            if (kullanici == null)
            {
                return null;
            }
            kullanici.KullaniciTip = Context.KullaniciTipi.FirstOrDefault(x => x.Id == kullanici.KullaniciTipId);
            return kullanici;
        }
    }
}
