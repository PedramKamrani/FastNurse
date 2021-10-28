using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Address
{
   public class Region:BaseEntite
    {
        public string Title { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
    }
}
