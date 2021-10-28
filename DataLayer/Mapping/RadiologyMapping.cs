using DataLayer.Entites.HospitalServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class RadiologyMapping : IEntityTypeConfiguration<Radiology>
    {
        public void Configure(EntityTypeBuilder<Radiology> builder)
        {
            builder.ToTable("Radiology");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(1000);
            builder.Property(x => x.Discreaption).HasMaxLength(2000);
            builder.Property(x => x.DiscreaptionAdmin).HasMaxLength(2000);
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
