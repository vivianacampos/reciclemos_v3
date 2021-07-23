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
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int tipoUsu = 2;
            if (ChbCondiciones.Checked)
            {
                LblMensaje.Text = UsuarioControlador.addUser(TxtRut.Text, TxtNombre.Text, TxtApellido.Text, TxtCorreo.Text, TxtTelefono.Text, TxtDireccion.Text, TxtContrasena.Text, int.Parse(DdlComunas.SelectedValue), tipoUsu);
            }
            else
            {
                LblConfirma.Text = "Debe aceptar las condiciones de uso";
            }
            
        }
    }
}