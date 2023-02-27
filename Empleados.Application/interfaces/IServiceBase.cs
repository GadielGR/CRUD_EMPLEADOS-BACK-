using Empleados.Dominio.interfaces;

namespace Empleados.Application.interfaces
{
    public interface IServiceBase<TEntity, TEntityId>
    : IAgregar<TEntity>, IEditar<TEntity>, IEliminar<TEntityId>, IListar<TEntity, TEntityId>
    {

    }
}