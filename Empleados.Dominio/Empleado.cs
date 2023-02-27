using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados.Dominio
{
    public class Empleado
    {
        [Key]
        public int id { get; set; }
        public string foto { get; set; }
        public string nombreCompleto { get; set; }
        public string puestoDeTrabajo { get; set; }
        public decimal salario { get; set; }
        public string estatus { get; set; }
        public string fechaDeContratacion { get; set; }
        [ForeignKey("Beneficiario_Id")]
        public virtual Beneficiario beneficiario { get; set; }
    }
}