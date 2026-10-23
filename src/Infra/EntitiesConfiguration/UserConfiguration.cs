using API.Domain.Entities;
using API.Infra.Data.Context;
using API.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Infra.Data.Context.EntitiesConfiguration
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Profile).IsRequired();
            builder.HasMany(u => u.Registrations).
            WithOne(u => u.User).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }

}