using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Empleados.Dominio;
using Empleados.Infrastructure.Data.config;

namespace Empleados.Infrastructure.Data.context
{
    public class EmpleadoContext : DbContext
    {

        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var stringConnection = Environment.GetEnvironmentVariable("MYSQL_STRING_CONNECTION");
            options.UseMySql(stringConnection, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmpleadoConfig());
            builder.ApplyConfiguration(new BeneficiarioConfig());
        }
    }
}