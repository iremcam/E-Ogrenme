using InfinityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Business.CozumBL
{
    public class CozumBL
    {
        InfinityContext Context = new InfinityContext();

        public bool CozumEkle(Cozum cozum)
        {
            cozum.Id = 0;
            Context.Cozum.Add(cozum);
            Context.SaveChanges();

            return true;
        }
    }
}
