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

        public usuario findUserById(int idUsuario)
        {
            return dbc.usuario.Find(idUsuario);
        }

        public usuario findUserByRut(string rut)
        {
            var usu = from u in dbc.usuario
                      where u.rut == rut
                      select u;
            return usu.FirstOrDefault();
        }

        public usuario editUsuario(int idUsuario, string nombre, string apellido, string telefono)
        {
            usuario usuario = dbc.usuario.Find(idUsuario);
            usuario.nombre = nombre;
            usuario.apellido = apellido;
            usuario.telefono = telefono;
            dbc.SaveChanges();
            return usuario;
        }

        public usuario editPass(int idUsuario, string contrasena)
        {
            usuario usuario = dbc.usuario.Find(idUsuario);
            usuario.contrasena = contrasena;
            dbc.SaveChanges();
            return usuario;
        }

        public usuario edithUsuEmp(string rut, string correo, string telefono, string direccion, int idComuna)
        {
            usuario usu = findUserByRut(rut);
            usu.correo = correo;
            usu.telefono = telefono;
            usu.direccion = direccion;
            usu.idComuna = idComuna;
            dbc.SaveChanges();
            return usu;
        }
    }
}