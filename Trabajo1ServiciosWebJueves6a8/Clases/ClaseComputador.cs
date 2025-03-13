using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Trabajo1ServiciosWebJueves6a8.Models;

namespace Trabajo1ServiciosWebJueves6a8.Clases
{
    public class ClaseComputador
    {
        private AgenciaEntities db = new AgenciaEntities();

        public computador computador { get; set; }

        public List<computador> ConsultarTodos()
        {
            return db.computadors.ToList();
        }

        public computador Consultar(int Codigo)
        {
            return db.computadors.Where(pc => pc.idcomputador == Codigo).FirstOrDefault();
        }

        public string Insertar()
        {
            try
            {
                db.computadors.Add(computador);
                db.SaveChanges();
                return "Computador insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el computador: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                computador pc = Consultar(computador.idcomputador);

                if (pc == null)
                {
                    return "El Computador con el código ingresado no existe. Por tanto, no puede ser actualizado.";
                }

                db.computadors.AddOrUpdate(computador);
                db.SaveChanges();
                return "Computador modificado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Computador: " + ex.Message;
            }
        }

        public string Eliminar()
        {
            try
            {
                computador pc = Consultar(computador.idcomputador);

                if (pc == null)
                {
                    return "El Computador con el código ingresado no existe. Por tanto, no puede ser eliminado";
                }

                db.computadors.Remove(pc);
                db.SaveChanges();
                return "Computador eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Computador: " + ex.Message;
            }
        }
    }
}