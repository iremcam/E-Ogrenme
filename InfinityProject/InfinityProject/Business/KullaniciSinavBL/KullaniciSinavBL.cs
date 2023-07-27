using InfinityProject.Models;
using InfinityProject.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.KullaniciSinavBL
{
    public class KullaniciSinavBL
    {
        InfinityContext Context = new InfinityContext();
        public List<SinavKullanici> GetSinavKullaniciList()
        {
            KullaniciAtaDTO kullaniciAtaDTO = new KullaniciAtaDTO();
            List<SinavKullanici> sinavKullaniciList = Context.SinavKullanici.ToList();
            foreach (var sinavKullanici in sinavKullaniciList)
            {
                sinavKullanici.Kullanici = Context.Kullanici.FirstOrDefault(x => x.Id == sinavKullanici.KullaniciId);
                sinavKullanici.Sinav = Context.Sinav.FirstOrDefault(x => x.Id == sinavKullanici.SinavId);                
                

               
            }

            return sinavKullaniciList;
        }

        public bool KullaniciAta(SinavKullanici sinavKullanici)
        {
            sinavKullanici.Id = 0;
            Context.SinavKullanici.Add(sinavKullanici);
            Context.SaveChanges();

            return true;
        }
        public bool SinavBaslamaZamaniGuncelle(int id)
        {
            SinavKullanici sinavKullanici = Context.SinavKullanici.FirstOrDefault(x => x.Id == id);
            if (sinavKullanici.BaslamaTarihi==null)
            {
                sinavKullanici.BaslamaTarihi = DateTime.Now;
                Context.SinavKullanici.Update(sinavKullanici);
                Context.SaveChanges();
            }
            
            return true;
        }

        public bool SinavBitisZamaniGuncelle(int id)
        {
            SinavKullanici sinavKullanici = Context.SinavKullanici.FirstOrDefault(x => x.Id == id);
            if (sinavKullanici.KullaniciBitirmeTarihi == null)
            {
                sinavKullanici.KullaniciBitirmeTarihi = DateTime.Now;
                Context.SinavKullanici.Update(sinavKullanici);
                Context.SaveChanges();
            }

            return true;
        }
    }
}
