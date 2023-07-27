using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class SinavKullanici : Base
    {
        public int SinavId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? KullaniciBitirmeTarihi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Sinav Sinav { get; set; }
    }
}
