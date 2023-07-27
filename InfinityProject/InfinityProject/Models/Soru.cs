using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class Soru : Base
    {
        public Soru()
        {
            Secenek = new HashSet<Secenek>();
        }

        public int SoruTipiId { get; set; }
        public int KategoriId { get; set; }
        public string Icerik { get; set; }
        public int SinavId { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual SoruTipi SoruTipi { get; set; }
        public virtual Sinav Sinav { get; set; }
        public virtual ICollection<Secenek> Secenek { get; set; }
    }
}
