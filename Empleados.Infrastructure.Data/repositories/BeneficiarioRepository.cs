using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empleados.Dominio;
using Empleados.Dominio.interfaces.Repositorio;
using Empleados.Infrastructure.Data.context;

namespace Empleados.Infrastructure.Data.repositories
{
    public class BeneficiarioRepository : IRepositoryBeneficiario<Beneficiario, int>
    {

        private EmpleadoContext db;

        public BeneficiarioRepository(EmpleadoContext _db)
        {
            db = _db;
        }

        public Beneficiario Agregar(Beneficiario entidad)
        {
            db.Beneficiarios.Add(entidad);
            return entidad;
        }

        public Beneficiario Editar(Beneficiario entidad)
        {
            var beneficiario = db.Beneficiarios.Where(b => b.id == entidad.id).FirstOrDefault();
            if (beneficiario != null)
            {
                beneficiario.FechaDeNacimiento = entidad.FechaDeNacimiento;
                beneficiario.NombreCompleto = entidad.NombreCompleto;
                beneficiario.Parentesco = entidad.Parentesco;
                beneficiario.Sexo = entidad.Sexo;
                db.Entry(beneficiario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            return entidad;
        }

        public void Eliminar(int entidadId)
        {
            var empleado = db.Beneficiarios.Where(e => e.id == entidadId).FirstOrDefault();
            if (empleado != null)
            {
                db.Beneficiarios.Remove(empleado);
            }
        }

        public void GuardarCambios()
        {
            db.SaveChanges();
        }

        public List<Beneficiario> Listar()
        {
            return db.Beneficiarios.ToList();
        }

        public Beneficiario ObtenerPorId(int entidadId)
        {
            return db.Beneficiarios.Where(e => e.id == entidadId).FirstOrDefault();
        }
    }
}