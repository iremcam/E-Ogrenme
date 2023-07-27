using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models.DTOs
{
    public class KullaniciAtaDTO
    {
        public List<Kullanici> Kullanicis { get; set; }
        public List<Sinav> Sinavs { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int KullaniciId { get; set; }
        public int SinavId { get; set; }
    }
}
