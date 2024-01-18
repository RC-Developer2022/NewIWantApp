using IWantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IWantApp.Infra.Settings
{
    public class ProductSettings : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(255); 
        }
    }
}
