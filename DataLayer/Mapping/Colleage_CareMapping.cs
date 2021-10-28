using DataLayer.Entites.Colleagueandconsultants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataLayer.Mapping
{
    public class Colleage_CareMapping : IEntityTypeConfiguration<Colleage_Care>
    {
        public void Configure(EntityTypeBuilder<Colleage_Care> builder)
        {
            builder.HasKey(x =>x.Colleage_Careid);

            builder.HasOne(x => x.ColleagueAndConsultants)
                .WithMany(x => x.Colleage_Cares).HasForeignKey(x => x.ColleagueAndConsultantsId);

            builder.HasOne(x => x.CareAndMaintenance)
                .WithMany(x => x.Colleage_Cares).HasForeignKey(x => x.CareAndMaintenanceId);
        }
    }
}
