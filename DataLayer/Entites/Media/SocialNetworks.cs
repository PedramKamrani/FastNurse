using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites.Media
{
    /// <summary>
    /// شبکه های اجتماعی
    /// </summary>
   public class SocialNetworks:BaseEntite
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
    }
}
