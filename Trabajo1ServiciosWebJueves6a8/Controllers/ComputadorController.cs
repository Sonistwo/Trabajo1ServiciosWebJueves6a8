using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Trabajo1ServiciosWebJueves6a8.Models;

namespace Trabajo1ServiciosWebJueves6a8.Controllers
{
    [RoutePrefix("api/Computadores")]
    public class ComputadorController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<computador> ConsultarTodos()
        {
            return new Clases.ClaseComputador().ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public computador Consultar(int Codigo)
        {
            return new Clases.ClaseComputador().Consultar(Codigo);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] computador computador)
        {
            Clases.ClaseComputador clsComputador = new Clases.ClaseComputador();
            clsComputador.computador = computador;
            return clsComputador.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] computador computador)
        {
            Clases.ClaseComputador clsComputador = new Clases.ClaseComputador();
            clsComputador.computador = computador;
            return clsComputador.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int Codigo)
        {
            Clases.ClaseComputador clsComputador = new Clases.ClaseComputador();
            clsComputador.computador = clsComputador.Consultar(Codigo);
            return clsComputador.Eliminar();
        }


    }
}