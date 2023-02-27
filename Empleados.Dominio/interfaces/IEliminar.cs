using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados.Dominio.interfaces
{
    public interface IEliminar<TEntityId>
    {
        void Eliminar(TEntityId entidadId);
    }
}