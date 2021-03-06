using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Modelo;
using reciclemos_v3.Controladores;

namespace reciclemos_v3.PanelEmpresa
{
    public partial class ProspectosEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }
        public void CargarGrid()
        {
            using (reciclemosEntities dbc = new reciclemosEntities())
            {
                GdvMensajes.DataSource = from p in dbc.prospecto.ToList()
                                         from e in dbc.estado.ToList()
                                         where (p.idEstado == e.idEstado)
                                         select new
                                         {
                                             idProspecto = p.idProspecto,
                                             nombre = p.nombre,
                                             correo = p.correo,
                                             telefono = p.telefono,
                                             mensaje = p.mensaje,
                                             estado = p.estado.estado1
                                         };
                GdvMensajes.DataBind();
            }
        }

        public void filtrarGrid(int id)
        {
            using (reciclemosEntities dbc = new reciclemosEntities())
            {
                GdvMensajes.DataSource = from p in dbc.prospecto.ToList()
                                         from e in dbc.estado.ToList()
                                         where (p.idEstado == e.idEstado && p.idEstado == id)
                                         select new
                                         {
                                             idProspecto = p.idProspecto,
                                             nombre = p.nombre,
                                             correo = p.correo,
                                             telefono = p.telefono,
                                             mensaje = p.mensaje,
                                             estado = p.estado.estado1
                                         };
                GdvMensajes.DataBind();
            }
        }
        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            filtrarGrid(int.Parse(DdlFiltrar.SelectedValue));
        }
    }
}