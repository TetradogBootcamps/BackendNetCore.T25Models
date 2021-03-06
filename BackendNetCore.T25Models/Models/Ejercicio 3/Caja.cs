using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models.Models.Ejercicio_3
{
    public class Caja
    {
        [Key,MaxLength(5)]
        public string NumReferencia { get; set; }
        [MaxLength(100)]
        public string Contenido { get; set; }
        public int Valor { get; set; }

        public int AlmacenId { get; set; }
        [JsonIgnore]
        public Almacen Almacen { get; set; }
    }
}
