using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Controladores;
using reciclemos_v3.Modelo;

namespace reciclemos_v3.Formularios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            usuario user = new usuario();
            List<usuario> usu = LoginControlador.logear(TxtCorreo.Text, TxtContrasena.Text);
            foreach (usuario u in usu)
            {
                user.nombre = u.nombre;
                user.apellido = u.apellido;
                user.idTipoUsu = u.idTipoUsu;
                user.idUsuario = u.idUsuario;
            }
            if (user != null)
            {
                if (user.idTipoUsu == 1) 
                {
                    Session["Admin"] = user;
                    Response.Redirect("../PanelEmpresa/ClientesEmpresa.aspx");
                }else if (user.idTipoUsu == 2)
                {
                    Session["Usuario"] = user;
                    Response.Redirect("../PanelUsuario/SolicitudesUsuario.aspx");
                }
            }
            else
            {
                LblMensaje.Text = "Correo o contrasena incorrecta";
            }
        }
    }
}