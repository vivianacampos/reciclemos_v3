using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Controladores;
using reciclemos_v3.Modelo;


namespace reciclemos_v3.PanelUsuario
{
    public partial class MensajesUsuario : System.Web.UI.Page
    {
        usuario usu = new usuario();
        int idUsu = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                usu = (usuario)Session["Usuario"];
                idUsu = usu.idUsuario;
            }
            if (!IsPostBack) {
                LblUser.Text = usu.nombre + " " + usu.apellido;
                LblUsuario.Text = usu.nombre + " " + usu.apellido;
            }
            
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}