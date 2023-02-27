using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados.Dominio.interfaces
{
    public interface IEditar<TEditar>
    {
        TEditar Editar(TEditar entidad);



    }
}