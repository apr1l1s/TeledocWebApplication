

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.Core.Configuration
{
    public class ClientConfiguration
        : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(client => client.id);
            builder.HasIndex(client => client.id).IsUnique();
            builder.Property(client => client.inn).HasMaxLength(12);
            builder.Property(client => client.title).HasMaxLength(100);
        }
    }
}
