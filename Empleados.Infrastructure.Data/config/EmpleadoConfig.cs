using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Empleados.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Empleados.Infrastructure.Data.config
{
    public class EmpleadoConfig : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleados");
            builder.HasKey(e => e.id);
            builder.HasOne(empleado => empleado.beneficiario);
        }
    }
}