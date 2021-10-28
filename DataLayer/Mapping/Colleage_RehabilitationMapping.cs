using DataLayer.Entites.Colleagueandconsultants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public class Colleage_RehabilitationMapping : IEntityTypeConfiguration<Colleage_Rehabilitation>
    {
        public void Configure(EntityTypeBuilder<Colleage_Rehabilitation> builder)
        {
            builder.HasKey(x => x.ColleageRehabilitationid);

            builder.HasOne(x => x.ColleagueAndConsultants)
                .WithMany(x => x.Colleage_Rehabilitations).HasForeignKey(x => x.ColleagueAndConsultantsId);

            builder.HasOne(x => x.CareAndMaintenance)
                .WithMany(x => x.Colleage_Rehabilitations).HasForeignKey(x => x.RehabilitationAndSpeechtherapyId);
        }
    }
}
