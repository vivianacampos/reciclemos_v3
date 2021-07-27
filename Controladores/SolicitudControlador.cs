using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reciclemos_v3.Modelo;
using reciclemos_v3.Clases;
using System.Data;

namespace reciclemos_v3.Controladores
{
    public class SolicitudControlador
    {
        private static reciclemosEntities dbc = new reciclemosEntities();

        public static string addSolicitud(int idUsuario, List<Materiales> listaMat, int idEstado, DateTime fecha, string horario, string descripcion)
        {
            solicitud sol = new solicitud()
            {
                idUsuario = idUsuario,
                idEstado = idEstado
            };
            dbc.solicitud.Add(sol);
            dbc.SaveChanges();


            var id = dbc.solicitud
                       .OrderByDescending(p => p.idSolicitud)
                       .FirstOrDefault();

            foreach (Materiales m in listaMat)
            {
                solicitud_detalle solDet = new solicitud_detalle()
                {
                    idSolicitud = id.idSolicitud,
                    idMat = m.IdMaterial,
                    cantidad = m.Cantidad,
                    fecha = fecha,
                    horario = horario,
                    descripcion = descripcion
                };
                dbc.solicitud_detalle.Add(solDet);
                dbc.SaveChanges();
            }
            return "Solicitud registrada con exito";
        }
    }
}