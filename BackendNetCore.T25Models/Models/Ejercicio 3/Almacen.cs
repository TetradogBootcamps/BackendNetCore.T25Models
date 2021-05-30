using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models.Models.Ejercicio_3
{
    public class Almacen
    {
        [Key]
        public int Codigo { get; set; }
        [MaxLength(100)]
        public string Lugar { get; set; }
        public int Capacidad { get; set; }
    }
}
