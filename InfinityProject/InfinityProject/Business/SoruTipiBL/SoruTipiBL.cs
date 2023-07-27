using InfinityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.SoruTipiBL
{
    public class SoruTipiBL
    {
        InfinityContext Context = new InfinityContext();
        public List<SoruTipi> GetSoruTipiList()
        {
            List<SoruTipi> soruTipiList = Context.SoruTipi.ToList();

            return soruTipiList;
        }

    }
}
