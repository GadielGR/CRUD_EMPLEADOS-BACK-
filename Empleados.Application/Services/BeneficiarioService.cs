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
    public class BeneficiarioService : IBeneficiarioService<Beneficiario, int>
    {
        private readonly IRepository<Beneficiario, int> empleadoRepostiory;

        public BeneficiarioService(IRepository<Beneficiario, int> _empleadoRepository)
        {
            empleadoRepostiory = _empleadoRepository;
        }
        public Beneficiario Agregar(Beneficiario entidad)
        {
            if (entidad == null)
            {
                throw new Exception("El beneficiario es requerido.");
            }
            var result = empleadoRepostiory.Agregar(entidad);
            empleadoRepostiory.GuardarCambios();
            return result;
        }

        public Beneficiario Editar(Beneficiario entidad)
        {
            if (entidad == null)
            {
                throw new Exception("El beneficiario es requerido.");
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

        public List<Beneficiario> Listar()
        {
            return empleadoRepostiory.Listar();
        }

        public Beneficiario ObtenerPorId(int entidadId)
        {
            return empleadoRepostiory.ObtenerPorId(entidadId);
        }

    }
}