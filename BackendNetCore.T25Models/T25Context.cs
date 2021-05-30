using BackendNetCore.T25Models.Models.Ejercicio_1;
using BackendNetCore.T25Models.Models.Ejercicio_2;
using BackendNetCore.T25Models.Models.Ejercicio_3;
using BackendNetCore.T25Models.Models.Ejercicio_4;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models
{
    public class T25Context:DbContext
    {
        public T25Context(DbContextOptions<T25Context> options)
       : base(options)
        {
        }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Emplados { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Sala> Salas { get; set; }

    }
}
