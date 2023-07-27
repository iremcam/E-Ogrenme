using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models
{
    public class Cozum : Base
    {
        public int KullaniciId { get; set; }
        public int SinavId { get; set; }
        public int SoruId { get; set; }
        public int? SecenekId { get; set; }
        public string SecenekAciklama { get; set; }
    }
}
