using DataLayer.Entites.ServicesNurse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Colleagueandconsultants
{
   public class Colleage_Rehabilitation
    {
        public int ColleageRehabilitationid { get; set; }
        public int ColleagueAndConsultantsId { get; set; }
        public int RehabilitationAndSpeechtherapyId { get; set; }

        public ColleagueAndConsultants ColleagueAndConsultants { get; set; }
        public RehabilitationAndSpeechtherapy CareAndMaintenance { get; set; }
    }
}
