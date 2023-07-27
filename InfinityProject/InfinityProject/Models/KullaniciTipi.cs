using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class KullaniciTipi : Base
    {
        public KullaniciTipi()
        {
            Kullanici = new HashSet<Kullanici>();
        }

        public string KullaniciTipAdi { get; set; }

        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
