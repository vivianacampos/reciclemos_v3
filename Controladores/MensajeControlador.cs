using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.Controladores
{
    public class MensajeControlador
    {
        private static reciclemosEntities dbc = new reciclemosEntities();



        public string addProspecto(string nombre, string correo, string telefono, string mensaje, int idEstado) {
            prospecto p = new prospecto()
            {
                nombre = nombre,
                correo = correo,
                telefono = telefono,
                mensaje = mensaje,
                idEstado = idEstado
            };
            dbc.prospecto.Add(p);
            dbc.SaveChanges();
            
            return "Mensaje enviado";
        }
    }
}