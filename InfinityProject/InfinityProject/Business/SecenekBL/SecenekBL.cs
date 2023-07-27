using InfinityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.SecenekBL
{
    public class SecenekBL
    {
        InfinityContext Context = new InfinityContext();
        public List<Secenek> GetSecenekList( int soruId)
        {
            List<Secenek> secenekList = Context.Secenek.Where(x => x.SoruId == soruId).ToList();
          
            return secenekList;

        }

        public bool SecenekEkle(Secenek secenek)
        {
            secenek.Id = 0;
            Context.Secenek.Add(secenek);
            Context.SaveChanges();

            return true;
        }
    }
}
