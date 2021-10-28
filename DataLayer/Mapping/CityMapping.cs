using DataLayer.Entites.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cites");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();


            builder.HasOne(x => x.Provce).WithMany(x => x.Cities).HasForeignKey(x => x.ProvceId);
            builder.HasMany(x => x.Regions).WithOne(x => x.City).HasForeignKey(x => x.CityId);
        }
    }
}
