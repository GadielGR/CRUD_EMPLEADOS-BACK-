using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Empleados.Dominio;
using Empleados.Dominio.interfaces.Repositorio;
using Empleados.Infrastructure.Data.context;

namespace Empleados.Infrastructure.Data.repositories
{
    public class EmpleadoRepository : IRepositoryEmpleado<Empleado, int>
    {

        private EmpleadoContext db;
        private BeneficiarioRepository beneficiarioRepository;

        public EmpleadoRepository(EmpleadoContext _db)
        {
            db = _db;
            beneficiarioRepository = new BeneficiarioRepository(db);
        }

        public Empleado Agregar(Empleado entidad)
        {
            db.Empleados.Add(entidad);
            return entidad;
        }

        public Empleado Editar(Empleado entidad)
        {
            var empleado = db.Empleados.Where(e => e.id == entidad.id).FirstOrDefault();
            if (empleado != null)
            {
                empleado.nombreCompleto = entidad.nombreCompleto;
                empleado.beneficiario = entidad.beneficiario;
                empleado.fechaDeContratacion = entidad.fechaDeContratacion;
                empleado.foto = entidad.foto;
                empleado.puestoDeTrabajo = entidad.puestoDeTrabajo;
                empleado.salario = entidad.salario;

                db.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                var beneficiario = db.Beneficiarios.Where(b => b.id == empleado.beneficiario.id).FirstOrDefault();
                if (beneficiario != null)
                {
                    beneficiarioRepository.Editar(beneficiario);
                }
            }

            return entidad;
        }

        public void Eliminar(int entidadId)
        {
            var empleado = db.Empleados.Where(e => e.id == entidadId).FirstOrDefault();
            if (empleado != null)
            {
                db.Empleados.Remove(empleado);
            }
        }

        public void GuardarCambios()
        {
            db.SaveChanges();
        }

        public List<Empleado> Listar()
        {
            return db.Empleados.Include("beneficiario").Where(e => e.estatus != "inactivo").ToList();
        }

        public Empleado ObtenerPorId(int entidadId)
        {
            return db.Empleados.Include("beneficiario").Where(e => e.id == entidadId).FirstOrDefault();
        }
    }
}