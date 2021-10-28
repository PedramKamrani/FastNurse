using DataLayer.Entites.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Image).HasMaxLength(1000);
            builder.Property(x => x.Discreaption).HasMaxLength(2000);

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.Prouducts).HasForeignKey(x => x.CategoryId);
        }
    }
}
