using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;

namespace BarC.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        [Required(ErrorMessage = "DNI incorrecto")]
        [StringLength(8, ErrorMessage = "El DNI debe tener como minimo 7 caracteres", MinimumLength = 7)]
        public string DNI { get; set; }
        public int Edad { get; set; }
        [Required(ErrorMessage = "Email es requerido")]
        [StringLength(30, ErrorMessage = "Debe ingresar un mail entre 5 y 30 caracteres", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Ingrese un imail valido")]
        public String Email { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public int  Role { get; set; }

    }
}
