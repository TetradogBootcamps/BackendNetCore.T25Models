using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
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
        [JsonIgnore]
        public Departamento Departamento { get; set; }
    }
}
