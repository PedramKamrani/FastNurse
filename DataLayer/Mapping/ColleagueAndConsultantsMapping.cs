using DataLayer.Entites.Colleagueandconsultants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class ColleagueAndConsultantsMapping : IEntityTypeConfiguration<ColleagueAndConsultants>
    {
        public void Configure(EntityTypeBuilder<ColleagueAndConsultants> builder)
        {
            builder.ToTable("ColleagueAndConsultants");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Famaily).HasMaxLength(500).IsRequired();
            builder.Property(x => x.NationalCode).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Mobaile).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(1000).IsRequired();


            builder.HasOne(x => x.Provce).WithMany(x => x.ColleagueAndConsultants).HasForeignKey(x => x.ProvceId);
            builder.HasOne(x => x.City).WithMany(x => x.ColleagueAndConsultants).HasForeignKey(x => x.CityId);
        }
    }
}
