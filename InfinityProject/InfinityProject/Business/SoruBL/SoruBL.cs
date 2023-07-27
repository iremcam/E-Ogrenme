using InfinityProject.Models;
using InfinityProject.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.SoruBL
{
    public class SoruBL
    {
        InfinityContext Context = new InfinityContext();
        public List<Soru> GetSoruList(int sinavId)
        {
            List<Soru> soruList = Context.Soru.Where(x => x.SinavId == sinavId).ToList();
            foreach (var soru in soruList)
            {
                soru.Kategori = Context.Kategori.FirstOrDefault(x => x.Id == soru.KategoriId);
                soru.SoruTipi = Context.SoruTipi.FirstOrDefault(x => x.Id == soru.SoruTipiId);
            }

            return soruList;
        }

        public bool SoruEkle(Soru soru)
        {
            soru.Id = 0;
            Context.Soru.Add(soru);
            Context.SaveChanges();

            return true;
        }

        public CozumDTO SınavSorusuGetir(int sinavKullaniciId, int kullaniciId)
        {
            CozumDTO cozumDTO = new CozumDTO();
            cozumDTO.KullaniciSinavId = sinavKullaniciId;
            SinavKullanici sinavKullanici = Context.SinavKullanici.Where(x => x.Id == sinavKullaniciId).FirstOrDefault();
            cozumDTO.BaslamaTarihi = sinavKullanici.BaslamaTarihi;
            cozumDTO.SinavId = sinavKullanici.SinavId;
            List<int> cozumler = Context.Cozum.Where(x => x.SinavId == sinavKullanici.SinavId && x.KullaniciId == kullaniciId).Select(x => x.SoruId).ToList();
            List<Soru> sorular = Context.Soru.Where(x => x.SinavId == sinavKullanici.SinavId && !cozumler.Contains(x.Id)).ToList();
            cozumDTO.Soru = sorular.FirstOrDefault();
            if (cozumDTO.Soru == null)
            {
                return null;
            }
            cozumDTO.Soru.SoruTipi = Context.SoruTipi.FirstOrDefault(x => x.Id == cozumDTO.Soru.SoruTipiId);
            cozumDTO.Secenek = Context.Secenek.Where(x => x.SoruId == cozumDTO.Soru.Id).ToList();
            cozumDTO.SinavSuresi = Context.Sinav.FirstOrDefault(x => x.Id == sinavKullanici.SinavId).SinavSuresi;
            cozumDTO.SinavBitisTarihi = sinavKullanici.BaslamaTarihi.Value.AddMinutes(cozumDTO.SinavSuresi);

            return cozumDTO;
        }

    }
}
