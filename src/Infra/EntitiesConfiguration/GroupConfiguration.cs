using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;
using API.Infra.Data.Context;
using API.Infra.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Infra.Data.Context.EntitiesConfiguration
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>{

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.GroupId).IsRequired();
            builder.Property(g => g.Name).IsRequired();
            builder.Property(g => g.Description);

            builder.HasMany(g => g.Registrations) 
            .WithOne(r => r.Group)           
            .HasForeignKey(r => r.GroupId);

        }
    }
}