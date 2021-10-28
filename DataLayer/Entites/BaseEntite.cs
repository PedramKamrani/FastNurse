using System;

namespace DataLayer.Entites
{
    public class BaseEntite
    {
        public int Id { get; set; }
        public DateTime CreaCreatetionDate { get; set; }
        public BaseEntite()
        {
            CreaCreatetionDate = DateTime.Now;
        }
    }
}
