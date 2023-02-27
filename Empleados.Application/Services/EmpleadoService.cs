using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Empleados.Application.interfaces;
using Empleados.Dominio.interfaces;
using Empleados.Dominio.interfaces.Repositorio;
using Empleados.Dominio;

namespace Empleados.Application.Services
{
    public class EmpleadoService : IEmpleadoService<Empleado, int>
    {
        private readonly IRepository<Empleado, int> empleadoRepostiory;

        public EmpleadoService(IRepository<Empleado, int> _empleadoRepository)
        {
            empleadoRepostiory = _empleadoRepository;
        }
        public Empleado Agregar(Empleado entidad)
        {
            if (entidad == null)
            {
                throw new Exception("El Empleado es requerido.");
            }
            var result = empleadoRepostiory.Agregar(entidad);
            empleadoRepostiory.GuardarCambios();
            return result;
        }

        public Empleado Editar(Empleado entidad)
        {
            if (entidad == null)
            {
                throw new Exception("El Empleado es requerido.");
            }
            var result = empleadoRepostiory.Editar(entidad);
            empleadoRepostiory.GuardarCambios();
            return result;
        }

        public void Eliminar(int entidadId)
        {
            empleadoRepostiory.Eliminar(entidadId);
            empleadoRepostiory.GuardarCambios();
        }

        public List<Empleado> Listar()
        {
            return empleadoRepostiory.Listar();
        }

        public Empleado ObtenerPorId(int entidadId)
        {
            return empleadoRepostiory.ObtenerPorId(entidadId);
        }

    }
}