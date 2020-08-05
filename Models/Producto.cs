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
    public class Producto
    {
        internal object id;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public double Precio { get; set; }
        
        public Pedido Pedido { get; set; }
        [ForeignKey("Pedido")]
       public int Pedidofk { get; set; }

    }
}
