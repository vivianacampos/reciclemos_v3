using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.PanelUsuario
{
    public partial class MisSolicitudesUsuario : System.Web.UI.Page
    {
        int idUsu = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            usuario usu = new usuario();
            if (Session["Usuario"] != null)
            {
                usu = (usuario)Session["Usuario"];
                idUsu = usu.idUsuario;
            }
            CargarGrid(idUsu);
        }

        public void CargarGrid(int id)
        {
            using (reciclemosEntities dbc = new reciclemosEntities())
            {
                GrdVSolicitudes.DataSource = from sol in dbc.solicitud.ToList()
                                             from solDet in dbc.solicitud_detalle.ToList()
                                             from m in dbc.materiales.ToList()
                                             from e in dbc.estado.ToList()
                                             where sol.idUsuario == id && sol.idSolicitud == solDet.idSolicitud && solDet.idMat == m.idMateriales && sol.idEstado == e.idEstado
                                             select new
                                             {
                                                 idSolicitud = sol.idSolicitud,
                                                 estado = e.estado1,
                                                 material = m.material,
                                                 cantidad = solDet.cantidad,
                                                 fecha = solDet.fecha,
                                                 horario = solDet.horario,
                                                 descripcion = solDet.descripcion,
                                             };
                GrdVSolicitudes.DataBind();

            }
        }
    }
}