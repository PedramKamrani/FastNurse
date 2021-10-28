using DataLayer.Entites.Colleagueandconsultants;
using System.Collections.Generic;

namespace DataLayer.Entites.ServicesNurse
{
    /// <summary>
    /// مراقبت و نگهداری
    /// </summary>
    public class CareAndMaintenance : BaseEntite
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Images { get; set; }
        public string Discreaption { get; set; }
        public string DiscreaptionAdmin { get; set; }

        public List<Colleage_Care> Colleage_Cares { get; set; }

    }
}
