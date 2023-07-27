using InfinityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.KategoriBL
{
    public class KategoriBL
    {
        InfinityContext Context = new InfinityContext();
        public List<Kategori> GetKategoriList()
        {
            List<Kategori> kategoriList = Context.Kategori.ToList();

            return kategoriList;
        }

        public bool KategoriEkle(Kategori kategori)
        {
            kategori.Id = 0;
            Context.Kategori.Add(kategori);
            Context.SaveChanges();

            return true;
        }
    }
}
