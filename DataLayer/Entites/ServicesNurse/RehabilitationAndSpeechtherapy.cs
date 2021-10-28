using DataLayer.Entites.Colleagueandconsultants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.ServicesNurse
{
    /// <summary>
    /// خدمات توانبخشی و گفتار درمانی
    /// </summary>
    public class RehabilitationAndSpeechtherapy:CareAndMaintenance
    {
        public List<Colleage_Rehabilitation> Colleage_Rehabilitations { get; set; }
    }
}
