using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Vacunate_RD.Data
{
    public class Vacuna
    {   
        [Key]
        public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        
 }
}