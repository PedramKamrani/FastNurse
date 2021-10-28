using DataLayer.Entites.Colleagueandconsultants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Address
{
   public class City:BaseEntite
    {
        public string Title { get; set; }
        public int ProvceId { get; set; }

        public Provce Provce { get; set; }

        public List<Region> Regions { get; set; }
        public List<ColleagueAndConsultants> ColleagueAndConsultants { get; set; }
    }
}
