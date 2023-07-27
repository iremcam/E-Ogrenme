using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class Secenek : Base
    {
        public int SoruId { get; set; }
        public string SecenekAciklamasi { get; set; }
        public bool DogruSecenek { get; set; }

        public virtual Soru Soru { get; set; }
    }
}
