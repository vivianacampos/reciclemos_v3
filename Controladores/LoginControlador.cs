using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.Controladores
{
    public class LoginControlador
    {
        private static reciclemosEntities dbc = new reciclemosEntities();

        public static List<usuario> logear(string correo, string contrasena)
        {
            var user = from u in dbc.usuario
                       where u.correo == correo && u.contrasena == contrasena
                       select u;

            return user.ToList();
        }

    }
}