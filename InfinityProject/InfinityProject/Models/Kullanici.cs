using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class Kullanici : Base
    {
        public Kullanici()
        {
            SinavKullanici = new HashSet<SinavKullanici>();
        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int KullaniciTipId { get; set; }

        public virtual KullaniciTipi KullaniciTip { get; set; }
        public virtual ICollection<SinavKullanici> SinavKullanici { get; set; }
    }
}
