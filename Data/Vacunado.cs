using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Vacunate_RD.Data
{
    public class Vacunado
    {   
        [Key]
        public int Id { get; set;}

        [StringLength(13)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }
        public string Teléfono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Dosis { get; set; }

 }
}