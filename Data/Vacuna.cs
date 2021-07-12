using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Vacunate_RD.Data
{
    public class Vacuna
    {   
        [Key]
        public int Id { get; set;}
        [Required]
        public int IdPersona { get; set;}
        public int idTipoVacuna  { get; set;} 
        [Required]
        public DateTime Fecha {get; set;}
        [Required]
        public int idProvincia { get; set; }

 }
}