using DataLayer.Entites.Address;
using System.Collections.Generic;

namespace DataLayer.Entites.Colleagueandconsultants
{/// <summary>
 /// همکاران و مشاوران
 /// </summary>
    public class ColleagueAndConsultants : BaseEntite
    {

        public string Name { get; set; }
        public string Famaily { get; set; }
        public int NationalCode { get; set; }
        public string Mobaile { get; set; }
        public string Address { get; set; }
        public int ProvceId { get; set; }
        public int CityId { get; set; }
        public int RegionId { get; set; }


        public Provce Provce { get; set; }
        public City City { get; set; }

        public List<Colleage_Care> Colleage_Cares { get; set; }
        public List<Colleage_Rehabilitation> Colleage_Rehabilitations { get; set; }

    }
}
