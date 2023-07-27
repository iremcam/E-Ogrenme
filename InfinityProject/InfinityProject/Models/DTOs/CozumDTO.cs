using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models.DTOs
{
    public class CozumDTO
    {
        public Soru Soru { get; set; }
        public List<Secenek> Secenek { get; set; }
        public int SinavId { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public int SinavSuresi { get; set; }
        public int KullaniciSinavId { get; set; }
        public DateTime SinavBitisTarihi { get; set; }
    }
}
