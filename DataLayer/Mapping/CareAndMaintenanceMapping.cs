using DataLayer.Entites.ServicesNurse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class CareAndMaintenanceMapping : IEntityTypeConfiguration<CareAndMaintenance>
    {
        public void Configure(EntityTypeBuilder<CareAndMaintenance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(900).IsRequired();
            builder.Property(x => x.Images).HasMaxLength(1000);
            builder.Property(x => x.Discreaption).HasMaxLength(2000);
            builder.Property(x => x.DiscreaptionAdmin).HasMaxLength(2000);
        }
    }
}
