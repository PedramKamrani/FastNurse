using DataLayer.Entites.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class AboutUsMapping : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.ToTable("AboutUs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(5000);
            builder.Property(x => x.Discreaption).HasMaxLength(2500);
        }
    }
}
