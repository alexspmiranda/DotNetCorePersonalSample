using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapper
{
    public class ProductMapper : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT").HasKey(u => u.IdProduct);
            builder.Property(u => u.IdProduct).HasColumnName("ID_PRODUCT");
            builder.Property(u => u.ProductName).HasColumnName("PRODUCT_NAME");
            builder.Property(u => u.IdProductClass).HasColumnName("ID_PRODUCT_CLASS");
        }
       
    }
    
}