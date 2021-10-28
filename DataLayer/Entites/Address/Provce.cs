using DataLayer.Entites.Colleagueandconsultants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Address
{
   public class Provce:BaseEntite
    {
        public string Title { get; set; }
        public List<City> Cities { get; set; }
        public List<ColleagueAndConsultants> ColleagueAndConsultants { get; set; }
    }
}
