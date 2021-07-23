using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.Controladores
{
    public class UsuarioControlador
    {
        private static reciclemosEntities dbc = new reciclemosEntities();

        public static string addUser(string rut, string nombre, string apellido, string correo, string telefono, string direccion, string contrasena, int idComuna, int tipoUsu)
        {
            usuario usu = new usuario()
            {
                rut = rut,
                nombre = nombre,
                apellido = apellido,
                correo = correo,
                telefono = telefono, 
                direccion = direccion,
                contrasena = contrasena,
                idComuna = idComuna,
                idTipoUsu = tipoUsu
            };
            dbc.usuario.Add(usu);
            dbc.SaveChanges();

            return "Usuario registrado con exito";
        }

        public static usuario findUserById(int idUsuario)
        {
            return dbc.usuario.Find(idUsuario);
        }

        public static usuario findUserByRut(string rut)
        {
            return dbc.usuario.Find(rut);
        }
    }
}