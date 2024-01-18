using IWantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IWantApp.Infra.Settings;

public sealed class CategorySettings : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Name).IsRequired();
    }
}
