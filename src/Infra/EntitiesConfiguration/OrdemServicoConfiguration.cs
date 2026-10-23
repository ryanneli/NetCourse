using Microsoft.EntityFrameworkCore;
using API.Infra.Data.Context;
using API.Infra.Repository;
using API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;

namespace API.Data.Context.EntitiesConfiguration
{
    public class OrdemServicoConfiguration : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasAlternateKey(o => o.Os);
            builder.Property(r => r.Cliente).IsRequired();
            builder.Property(r => r.Os).IsRequired();
            builder.HasMany(p => p.Pedidos).WithOne(r => r.OrdemServico).HasForeignKey(p => p.OsId).HasPrincipalKey(o => o.Os);
        }
    }
}