using Microsoft.EntityFrameworkCore;
using API.Infra.Data.Context;
using API.Infra.Repository;
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;

namespace API.Data.Context.EntitiesConfiguration
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.UserId).IsRequired();
            builder.Property(r => r.GroupId).IsRequired();

            builder.HasOne(x => x.User).
            WithMany(x => x.Registrations).
            HasForeignKey(x => x.UserId).
            OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Group).
            WithMany(x => x.Registrations).
            HasForeignKey(x => x.GroupId).
            OnDelete(DeleteBehavior.NoAction);


        }
    }
}