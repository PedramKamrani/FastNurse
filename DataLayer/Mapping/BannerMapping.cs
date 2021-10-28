using DataLayer.Entites.Banner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public class BannerMapping : IEntityTypeConfiguration<Banners>
    {
        public void Configure(EntityTypeBuilder<Banners> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Image).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Link).HasMaxLength(1000);
        }
    }
}
