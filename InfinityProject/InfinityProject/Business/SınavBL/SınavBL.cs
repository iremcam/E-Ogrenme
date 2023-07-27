using InfinityProject.Models;
using InfinityProject.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.SınavBL
{
    public class SınavBL
    {
        InfinityContext Context = new InfinityContext();
        public List<Sinav> GetSınavList()
        {
            List<Sinav> sinavList = Context.Sinav.ToList();

            return sinavList;
        }

        public bool SinavEkle(Sinav sinav)
        {
            Context.Sinav.Add(sinav);
            Context.SaveChanges();

            return true;
        }

        public List<SinavKullaniciDTO> KullaniciSinavlari(int kullaniciId)
        {
            DateTime today = DateTime.Now;
            List<SinavKullanici> kullaniciSinavlari = Context.SinavKullanici.Where(x => x.KullaniciId == kullaniciId && x.BaslangicTarihi <= today && x.BitisTarihi >= today).ToList();

            List<SinavKullaniciDTO> sinavList = new List<SinavKullaniciDTO>();
            foreach (var kSinav in kullaniciSinavlari)
            {
                SinavKullaniciDTO sKullaniciDTO = new SinavKullaniciDTO();
                sKullaniciDTO.SinavKullaniciId = kSinav.Id;
                sKullaniciDTO.KullaniciBitirmeTarihi = kSinav.KullaniciBitirmeTarihi;
                sKullaniciDTO.Sinav = Context.Sinav.FirstOrDefault(x => x.Id == kSinav.SinavId);
                if (sKullaniciDTO.KullaniciBitirmeTarihi != null)
                {
                    List<Cozum> cozumList = Context.Cozum.Where(x => x.KullaniciId == kullaniciId && x.SinavId == kSinav.SinavId).ToList();
                    float soruPuan = 100 / cozumList.Count;
                    float sonuc = 0;
                    foreach (var cozum in cozumList)
                    {
                        if (cozum.SecenekId != null)
                        {
                            var secenek = Context.Secenek.FirstOrDefault(x => x.Id == cozum.SecenekId);
                            if (secenek.DogruSecenek)
                            {
                                sonuc = sonuc + soruPuan;
                            }
                        }
                    }

                    sKullaniciDTO.Puan = sonuc.ToString();
                    sKullaniciDTO.Gecti = sonuc > sKullaniciDTO.Sinav.BasariPuani;
                }

                sinavList.Add(sKullaniciDTO);
            }

            return sinavList;
        }
    }
}
