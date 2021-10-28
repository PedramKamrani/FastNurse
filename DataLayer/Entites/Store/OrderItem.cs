using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Store
{
   public class OrderItem:BaseEntite
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
