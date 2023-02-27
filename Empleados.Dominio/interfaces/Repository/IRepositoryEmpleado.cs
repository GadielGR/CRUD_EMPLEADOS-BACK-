using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados.Dominio.interfaces.Repositorio
{
    public interface IRepositoryEmpleado<TEntity, TEntityId>
        : IRepository<TEntity, TEntityId>
    {

    }
}