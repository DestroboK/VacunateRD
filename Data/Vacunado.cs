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
        public string Fecha_nacimiento { get; set; }
        public int TipoVacuna { get; set; }
        public int Provincia { get; set; }
        public string Fecha_Dosis { get; set; }
        public string signo_zodiaco { get; set; }
    }
}