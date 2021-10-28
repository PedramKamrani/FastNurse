using DataLayer.Entites.ServicesNurse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Colleagueandconsultants
{/// <summary>
 /// جدول واسطه هشاوران و مراقبت
 /// </summary>
    public class Colleage_Care
    {
       public int Colleage_Careid{get;set;}
       public int ColleagueAndConsultantsId { get; set; }
       public int CareAndMaintenanceId { get; set; }

        public ColleagueAndConsultants ColleagueAndConsultants { get; set; }
        public CareAndMaintenance CareAndMaintenance { get; set; }
    }
}
