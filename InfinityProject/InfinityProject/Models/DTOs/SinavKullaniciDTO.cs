using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models.DTOs
{
    public class SinavKullaniciDTO
    {
        public int SinavKullaniciId { get; set; }
        public Sinav Sinav { get; set; }
        public string Puan { get; set; }
        public bool Gecti { get; set; }
        public DateTime? KullaniciBitirmeTarihi { get; set; }
    }
}
