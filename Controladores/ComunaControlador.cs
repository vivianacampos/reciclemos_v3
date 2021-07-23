using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.Controladores
{
    public class ComunaControlador
    {
        private static reciclemosEntities dbc = new reciclemosEntities();

        public static List<comuna> getAll()
        {
            var lista = from c in dbc.comuna
                        select c;
            return lista.ToList();
        }

    }
}