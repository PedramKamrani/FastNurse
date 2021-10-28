using DataLayer.Entites.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class ProvceMapping : IEntityTypeConfiguration<Provce>
    {
        public void Configure(EntityTypeBuilder<Provce> builder)
        {
            builder.ToTable("Provce");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(230).IsRequired();
        }
    }
}
