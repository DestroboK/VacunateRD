using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Vacunate_RD.Data
{
    public class Vacunado
    {
        [Key] 
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string TipoVacuna { get; set; }
        public string Provincia { get; set; }
        public DateTime Fecha_Dosis { get; set; }
        public string signo_zodiaco { get; set; }
    }
}