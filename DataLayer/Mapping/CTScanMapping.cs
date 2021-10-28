using DataLayer.Entites.HospitalServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public class CTScanMapping : IEntityTypeConfiguration<CTScan>
    {
        public void Configure(EntityTypeBuilder<CTScan> builder)
        {
            builder.ToTable("CTScan");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(1000);
            builder.Property(x => x.Discreaption).HasMaxLength(2000);
            builder.Property(x => x.DiscreaptionAdmin).HasMaxLength(2000);
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
