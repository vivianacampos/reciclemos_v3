using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reciclemos_v3.Clases
{
    public class Materiales
    {
        private int idMaterial;
        private string nombre;
        private int cantidad;
        private List<Materiales> listaMateriales;

        public Materiales()
        {
        }

        public Materiales(int idMaterial, int cantidad)
        {
            this.idMaterial = idMaterial;
            this.cantidad = cantidad;
        }

        public Materiales(int idMaterial, string nombre, int cantidad, List<Materiales> listaMateriales)
        {
            this.idMaterial = idMaterial;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.listaMateriales = listaMateriales;
        }

        public int IdMaterial { get => idMaterial; set => idMaterial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public List<Materiales> ListaMAteriales { get => listaMateriales; set => listaMateriales = value; }
    }
}