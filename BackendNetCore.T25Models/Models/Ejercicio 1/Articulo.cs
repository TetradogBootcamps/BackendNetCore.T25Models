using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models.Models.Ejercicio_1
{
    public class Articulo
    {
        [Key]
        public int Codigo { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public int FabricanteId { get; set; }
        [JsonIgnore]
        public Fabricante Fabricante { get; set; }

    }
}
