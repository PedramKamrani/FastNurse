using DataLayer.Entites.Media;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class SocialNetworksMapping : IEntityTypeConfiguration<SocialNetworks>
    {
        public void Configure(EntityTypeBuilder<SocialNetworks> builder)
        {
            builder.ToTable("SocialNetworks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Image).HasMaxLength(1000);
            builder.Property(x => x.Title).HasMaxLength(500);
            builder.Property(x => x.Link).HasMaxLength(1000);
        }
    }
}
