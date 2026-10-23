using Microsoft.EntityFrameworkCore;
using API.Infra.Data.Context;
using API.Infra.Repository;
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace API.Infra.Data.Context.EntitiesConfiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Description);
            builder.HasMany(g => g.Group).WithOne(c => c.Course).HasForeignKey(c => c.CourseId);
        }
    }
}
