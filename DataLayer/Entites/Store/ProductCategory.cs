using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Store
{
    public class ProductCategory : BaseEntite
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Discreaption { get; set; }

        public List<Product> Prouducts {get;set;}

    }
}
