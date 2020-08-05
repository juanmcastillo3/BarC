using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class Prod
    {
     
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public double Precio { get; set; }
    }
}
