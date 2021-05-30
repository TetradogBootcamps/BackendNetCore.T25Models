﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models.Models.Ejercicio_4
{
    public class Sala
    {
        [Key]
        public int Codigo { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int PeliculaId { get; set; }
    }
}
