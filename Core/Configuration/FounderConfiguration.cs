using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.Core.Configuration
{
    public class FounderConfiguration
     : IEntityTypeConfiguration<Founder>
    {
        public void Configure(EntityTypeBuilder<Founder> builder)
        {
            builder.HasKey(founder => founder.id);
            builder.HasIndex(founder => founder.id).IsUnique();
            builder.Property(founder => founder.inn).HasMaxLength(12);
            builder.Property(founder => founder.surname).HasMaxLength(50);
            builder.Property(founder => founder.name).HasMaxLength(40);
            builder.Property(founder => founder.middlename).HasMaxLength(60);
        }
    }
}
