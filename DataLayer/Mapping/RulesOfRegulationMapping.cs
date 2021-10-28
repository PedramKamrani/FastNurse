using DataLayer.Entites.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class RulesOfRegulationMapping : IEntityTypeConfiguration<RulesOfRegulation>
    {
        public void Configure(EntityTypeBuilder<RulesOfRegulation> builder)
        {
            builder.ToTable("RulesOfRegulation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(5000);
            builder.Property(x => x.Discreaption).HasMaxLength(3000);
        }
    }
}
