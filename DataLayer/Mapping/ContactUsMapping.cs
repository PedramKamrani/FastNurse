using DataLayer.Entites.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class ContactUsMapping : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {

            builder.ToTable("ContactUs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(5000);
            builder.Property(x => x.Discreaption).HasMaxLength(2500);
        }
    }
}
