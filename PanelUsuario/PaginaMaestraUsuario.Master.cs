using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.PanelUsuario
{
    public partial class PaginaMaestraUsuario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loginControl();
            usuario usu = new usuario();
            if (Session["Usuario"] != null)
            {
                usu = (usuario)Session["Usuario"];
                int idUsu = usu.idUsuario;
                LblUsuario.Text = "Bienvenido/a " + usu.nombre + " " + usu.apellido;
            }
        }

        public void loginControl()
        {
            if (Session["Usuario"] == null)
            {
                Session["error"] = "Debe estar registrado";
                Response.Redirect("../Formularios/Login.aspx");
            }
        }

        protected void ImgBtnLogout_Click(object sender, ImageClickEventArgs e)
        {
            Session["Usuario"] = null;
            Session["error"] = "Ha cerrado sesion";
            Response.Redirect("../Formularios/Login.aspx");
        }
    }
}