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
    public partial class SolicitudesEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }
        }

        public void cargarGrid()
        {
            using (reciclemosEntities dbc = new reciclemosEntities())
            {
                GdvSolicitudes.DataSource = from sol in dbc.solicitud.ToList()
                                            from solDet in dbc.solicitud_detalle.ToList()
                                            from u in dbc.usuario.ToList()
                                            from m in dbc.materiales.ToList()
                                            from e in dbc.estado.ToList()
                                            where (sol.idUsuario == u.idUsuario && sol.idEstado == e.idEstado && sol.idSolicitud == solDet.idSolicitud && solDet.idMat == m.idMateriales)
                                            select new
                                            {
                                                idSolicitud = sol.idSolicitud,
                                                nombre = sol.usuario.nombre,
                                                apellido = sol.usuario.apellido,
                                                direccion = sol.usuario.direccion,
                                                fecha = solDet.fecha,
                                                horario = solDet.horario,
                                                material = solDet.materiales.material,
                                                cantidad = solDet.cantidad,
                                                estado = sol.estado.estado1
                                            };
                GdvSolicitudes.DataBind();
            }
        }

        public void filtrarGrid(int id)
        {
            using (reciclemosEntities dbc = new reciclemosEntities())
            {
                GdvSolicitudes.DataSource = from sol in dbc.solicitud.ToList()
                                            from solDet in dbc.solicitud_detalle.ToList()
                                            from u in dbc.usuario.ToList()
                                            from m in dbc.materiales.ToList()
                                            from e in dbc.estado.ToList()
                                            where (sol.idUsuario == u.idUsuario && sol.idEstado == e.idEstado && sol.idSolicitud == solDet.idSolicitud && solDet.idMat == m.idMateriales && sol.idEstado == id)
                                            select new
                                            {
                                                idSolicitud = sol.idSolicitud,
                                                nombre = sol.usuario.nombre,
                                                apellido = sol.usuario.apellido,
                                                direccion = sol.usuario.direccion,
                                                fecha = solDet.fecha,
                                                horario = solDet.horario,
                                                material = solDet.materiales.material,
                                                cantidad = solDet.cantidad,
                                                estado = sol.estado.estado1,
                                            };
                GdvSolicitudes.DataBind();
            }
        }
        protected void BtnFiltrar_Click(object sender, EventArgs ex)
        {
            filtrarGrid(int.Parse(DdlFiltrarSol.SelectedValue));
        }
    }
}