using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.HospitalServices
{
   public class sonography:BaseEntite
    {
        public string Title { get; set; }
        public byte cooperationbenefits { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string Discreaption { get; set; }
        public string DiscreaptionAdmin { get; set; }
    }
}
