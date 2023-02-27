using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empleados.Dominio
{
    public class Beneficiario
    {
        [Key]
        public int id { set; get; }
        public string NombreCompleto { get; set; }
        public string Parentesco { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
    }
}