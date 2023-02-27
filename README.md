# CRUD Empleados REST API

Este proyecto utiliza las siguientes tecnologias:
* .Net 6
* Mysql 8

## Inicar el proyecto para desarrollo

- clonarse el proyecto

- Crear la una variable de entorno MYSQL_STRING_CONNECTION con la cadena de conexion a mysql

- correr el proyecto Empelados.Infrastructure.Data. Esto generara la base de datos y la tabla para correr esta api

- correr el proyecto Empelados.Infrastructure.API. Esto levantara el servicio en el puerto 5000

## Estructura del proyecto:

    src/
    ├─ Empleados.Application/
    │ ├─ interfaces/
    │ | ├─ IBeneficiarioService.cs
    │ | ├─ IEmpleadoService.cs
    │ | ├─ IServiceBase.cs
    │ ├─ services/
    │ │ ├─ BeneficiarioService.cs
    │ │ ├─ EmpleadoService.cs
    ├─ Empleados.Dominio/
    │ ├─ Beneficiario.cs/
    │ ├─ Empleado.cs/
    │ ├─ interfaces/
    │ │ ├─ repository/
    | │ │ ├─ IRepository.cs
    | │ │ ├─ IRepositoryBeneficiario.cs
    | │ │ ├─ IRepositoryEmpleado.cs
    │ │ ├─ IAgregar.cs
    │ │ ├─ IEditar.cs
    │ │ ├─ IEliminar.cs
    │ │ ├─ IListar.cs
    │ │ ├─ ITransaccion.cs
    ├─ Empleados.Infrastructure.Data/
    │ ├─ Config
    | | ├─ BeneficiarioConfig.cs
    | | ├─ EmpleadoConfig.cs
    │ ├─ Repositories
    | | ├─ BeneficiarioRepository.cs
    | | ├─ EmpleadoRepository.cs
    │ ├─ Config
    | | ├─ EmpleadoContext.cs
    ├─ Empleados.Infrastructure.API/
    │ ├─ Controllers
    | | ├─ EmpleadoController.cs

## TODO

### Actividades Pendientes

- [ ] Automatizacion
  - [ ] automatizar despliegue
- [ ] Validaciones
  - [ ] Agregar Validaciones de requerido
  - [ ] Implementar estatus http
- [ ] Catalogos
  - [ ] Agregar CRUD catalogos Parentesco
  - [ ] Agregar CRUD catalogos Puesto Trabajo
