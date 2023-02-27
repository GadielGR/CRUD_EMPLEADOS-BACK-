using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Empleados.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Empleados.Infrastructure.Data.config
{
    public class BeneficiarioConfig : IEntityTypeConfiguration<Beneficiario>
    {
        public void Configure(EntityTypeBuilder<Beneficiario> builder)
        {
            builder.ToTable("beneficiario");
            builder.HasKey(e => e.id);
        }
    }
}