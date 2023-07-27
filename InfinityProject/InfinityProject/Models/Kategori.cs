using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class Kategori : Base
    {
        public Kategori()
        {
            Soru = new HashSet<Soru>();
        }

        public string KategoriAdi { get; set; }

        public virtual ICollection<Soru> Soru { get; set; }
    }
}
