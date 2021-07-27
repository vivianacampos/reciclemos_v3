using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reciclemos_v3.Clases
{
    public class Solicitud
    {
        private int idSol;
        private int idUsuario;
        private string estado;
        private DateTime fecha;
        private string horario;
        private string detalle;
        private Materiales material;
        private Materiales cantidad;

        public Solicitud()
        {
        }

        public Solicitud(int idSol, int idUsuario, string estado, DateTime fecha, string horario, string detalle, Materiales material, Materiales cantidad)
        {
            this.idSol = idSol;
            this.idUsuario = idUsuario;
            this.estado = estado;
            this.fecha = fecha;
            this.horario = horario;
            this.detalle = detalle;
            this.material = material;
            this.cantidad = cantidad;
        }

        public int IdSol { get => idSol; set => idSol = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Materiales Material { get => material; set => material = value; }
        public Materiales Cantidad { get => cantidad; set => cantidad = value; }
    }

}