using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models.DTOs
{
    public class SoruOlusturDTO
    {
        public List<Kategori> KategoriList { get; set; }
        public List<SoruTipi> SoruTipiList { get; set; }
        public int SinavId { get; set; }
    }
}
