using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Store
{
   public class Order:BaseEntite
    {
        public int AccountId { get; set;}
        public double TotalAmount { get; set; }
        public double PayAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCanceled { get; set; }
        public string IssueTrackingNo { get; set; }
        public long RefId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
