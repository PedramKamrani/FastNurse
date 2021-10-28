using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.ServicesNurse
{
    public class ServiceNures : BaseEntite
    {
        public string Title { get; set; }
        public byte cooperationbenefits { get; set; }
        public string image { get; set; }
        public string Discreaption { get; set; }
        public string DiscreaptionAdmin { get; set; }
        public double Price { get; set; }
        public bool Needadvice { get; set; }

    }
}
