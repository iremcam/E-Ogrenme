using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class Sinav : Base
    {
        public Sinav()
        {
            SinavKullanici = new HashSet<SinavKullanici>();
            Soru = new HashSet<Soru>();
        }

        public int SinavSuresi { get; set; }
        public int BasariPuani { get; set; }
        public string SinavAdi { get; set; }

        public virtual ICollection<SinavKullanici> SinavKullanici { get; set; }
        public virtual ICollection<Soru> Soru { get; set; }
    }
}
