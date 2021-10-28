namespace DataLayer.Entites.HospitalServices
{/// <summary>
/// سی تی اسکن
/// </summary>
    public class CTScan : BaseEntite
    {
        public string Title { get; set; }
        public byte cooperationbenefits { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string Discreaption { get; set; }
        public string DiscreaptionAdmin { get; set; }
    }
}
