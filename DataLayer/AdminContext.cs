using DataLayer.Entites.Address;
using DataLayer.Entites.Banner;
using DataLayer.Entites.Colleagueandconsultants;
using DataLayer.Entites.HospitalServices;
using DataLayer.Entites.Media;
using DataLayer.Entites.Pages;
using DataLayer.Entites.ServicesNurse;
using DataLayer.Entites.Store;
using DataLayer.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataLayer
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assambely = typeof(CityMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assambely);


            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

        }

        #region Banner
        public DbSet<Banners> Banners { get; set; }
        #endregion

        #region Adderss
        public DbSet<City> Cities { get; set; }
        public DbSet<Provce> Provces { get; set; }
        public DbSet<Region> Regions { get; set; }

        #endregion

        #region ColleageAndConsultants
        public DbSet<Colleage_Care> Colleage_Cares { get; set; }
        public DbSet<Colleage_Rehabilitation> Colleage_Rehabilitations { get; set; }
        public DbSet<ColleagueAndConsultants> ColleagueAndConsultants { get; set; }
        #endregion

        #region HospitalService
        public DbSet<CTScan> CTScans { get; set; }
        public DbSet<Radiology> Radiologies { get; set; }
        public DbSet<sonography> Sonographies { get; set; }
        #endregion

        #region Meadia
        public DbSet<SocialNetworks> SocialNetworks { get; set; }
        #endregion

        #region Page
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<RulesOfRegulation> RulesOfRegulations { get; set; }
        #endregion

        #region ServicesNurse
        public DbSet<CareAndMaintenance> CareAndMaintenances { get; set; }
        public DbSet<RehabilitationAndSpeechtherapy> RehabilitationAndSpeechtherapies { get; set; }
        public DbSet<ServiceNures> ServiceNures { get; set; }
        #endregion

        #region Store
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        #endregion
    }
}


