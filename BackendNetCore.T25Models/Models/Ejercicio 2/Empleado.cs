using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models.Models.Ejercicio_2
{
    public class Empleado
    {
        [Key,MaxLength(8)]
        public string DNI { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string Apellidos { get; set; }
        public int DepartamentoId { get; set; }
    }
}
