using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;
using API.Infra.Data.Context;
using API.Infra.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Infra.Data.Context.EntitiesCOnfiguration
{
    public class ScoreConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.RegistrationId).IsRequired();
            builder.Property(s => s.Value).IsRequired();
            builder.HasOne(s => s.Registration).WithMany(s => s.Scores).HasForeignKey(s => s.RegistrationId).OnDelete(DeleteBehavior.NoAction);


        }
    }

}