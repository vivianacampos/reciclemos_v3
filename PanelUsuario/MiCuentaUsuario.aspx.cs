using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Modelo;
using reciclemos_v3.Controladores;
using System.Drawing;

namespace reciclemos_v3.PanelUsuario
{
    public partial class MiCuentaUsuario : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                CargarCampos(idUsu);
            }
        }
        public void CargarCampos(int idUsuario)
        {
            UsuarioControlador user = new UsuarioControlador();
            usuario u = new usuario();
            u = user.findUserById(idUsuario);
            if (u != null)
            {
                TxtRut.Text = u.rut;
                TxtNombre.Text = u.nombre;
                TxtApellido.Text = u.apellido;
                TxtCorreo.Text = u.correo;
                TxtDireccion.Text = u.direccion;
                TxtTelefono.Text = u.telefono;
                DdlComunas.SelectedValue = u.idComuna.ToString();
            }
        }

        protected void LnkBContrasena_Click(object sender, EventArgs e)
        {
            if (LnkBContrasena.Text == "Modificar Contraseña")
            {
                TxtContrasena.Visible = true;
                TxtConfirma.Visible = true;
                TxtVerifica.Visible = true;
                LnkBContrasena.Text = "Ocultar";
            }
            else if (LnkBContrasena.Text == "Ocultar")
            {
                TxtContrasena.Visible = false;
                TxtConfirma.Visible = false;
                TxtVerifica.Visible = false;
                LnkBContrasena.Text = "Modificar Contraseña";
            }

        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (BtnModificar.Text == "Modificar")
            {
                TxtNombre.Enabled = true;
                TxtApellido.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtTelefono.Enabled = true;
                BtnModificar.Text = "Guardar";

                if (LnkBContrasena.Text == "Ocultar")
                {
                    UsuarioControlador u = new UsuarioControlador();
                    usuario user = new usuario();
                    user = u.findUserById(idUsu);
                    if (user != null)
                    {
                        if (user.contrasena.Equals(TxtContrasena.Text))
                        {
                            if (TxtConfirma.Text == TxtVerifica.Text)
                            {
                                u.editPass(idUsu, TxtConfirma.Text);
                                LblMensaje.Text = "Contraseña modificada exitosamente";
                                LblMensaje.ForeColor = Color.Green;
                                TxtContrasena.Text = "";
                                TxtConfirma.Text = "";
                                TxtVerifica.Text = "";
                                TxtContrasena.Visible = false;
                                TxtConfirma.Visible = false;
                                TxtVerifica.Visible = false;
                                BtnModificar.Text = "Modificar";

                            }
                            else
                            {
                                LblMensaje.Text = "Ambos campos de nueva contraseña deben coincidir";
                                LblMensaje.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            LblMensaje.Text = "Contraseña actual no coincide";
                            LblMensaje.ForeColor = Color.Red;
                        }
                    }
                    
                }
                else if (LnkBContrasena.Text == "Modificar Contraseña")
                {
                    LblMensaje.Visible = false;
                }

            }
            else
            {
                UsuarioControlador usu = new UsuarioControlador();
                usu.editUsuario(idUsu, TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text);
                CargarCampos(idUsu);
                TxtNombre.Enabled = false;
                TxtApellido.Enabled = false;
                TxtDireccion.Enabled = false;
                TxtTelefono.Enabled = false;

                BtnModificar.Text = "Modificar";
            }
        }
    }
}