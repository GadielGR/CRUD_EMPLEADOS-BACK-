using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados.Dominio.interfaces.Repositorio
{
    public interface IRepository<TEntity, TEntityId>
    : IAgregar<TEntity>, IEditar<TEntity>, IEliminar<TEntityId>, IListar<TEntity, TEntityId>, ITransaccion
    {


    }
}