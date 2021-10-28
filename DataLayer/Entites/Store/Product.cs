using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Store
{
   public class Product:BaseEntite
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Discreaption { get; set; }
        public double Price { get; set; }
        public bool status { get; set; }
        public byte Rentaltime { get; set; }
        /// <summary>
        /// مدت اجاره
        /// </summary>
        public int CategoryId { get; set; }
        public bool WillRenew { get; set; }
        /// <summary>
        /// تمدید میکنم
        /// </summary>
        /// 
        public ProductCategory ProductCategory { get; set; }
    }
}
