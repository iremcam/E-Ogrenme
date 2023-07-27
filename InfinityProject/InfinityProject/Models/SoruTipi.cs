using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models
{
    public class SoruTipi : Base
    {
        public SoruTipi()
        {
            Soru = new HashSet<Soru>();

        }
        public string SoruTipiAdi { get; set; }

        public virtual ICollection<Soru> Soru { get; set; }

    }
}
