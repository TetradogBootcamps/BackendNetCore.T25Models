using BackendNetCore.T25Models.Models.Ejercicio_1;
using BackendNetCore.T25Models.Models.Ejercicio_2;
using BackendNetCore.T25Models.Models.Ejercicio_3;
using BackendNetCore.T25Models.Models.Ejercicio_4;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendNetCore.T25Models
{
    /*esta clase solo tiene el fin de rellenar la documentación para hacerlo más visual al ejecutar el ejercicio*/
    [ApiController]
    [Route("api/[controller]")]
    public class IndexController : ControllerBase
    {
      [HttpGet("Ejercicio1")]
      public ActionResult<KeyValuePair<Fabricante,Articulo>> GetEjercicio1()
        {
            return new KeyValuePair<Fabricante, Articulo>(new Fabricante(),new Articulo());
        }
        [HttpGet("Ejercicio2")]
        public ActionResult<KeyValuePair<Departamento, Empleado>> GetEjercicio2()
        {
            return new KeyValuePair<Departamento, Empleado>(new Departamento(), new Empleado());
        }
        [HttpGet("Ejercicio3")]
        public ActionResult<KeyValuePair<Almacen, Caja>> GetEjercicio3()
        {
            return new KeyValuePair<Almacen, Caja>(new Almacen(), new Caja());
        }
        [HttpGet("Ejercicio4")]
        public ActionResult<KeyValuePair<Pelicula, Sala>> GetEjercicio4()
        {
            return new KeyValuePair<Pelicula, Sala>(new Pelicula(), new Sala());
        }
    }
}
