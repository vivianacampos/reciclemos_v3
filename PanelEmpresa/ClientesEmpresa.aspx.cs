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
    public partial class ClientesEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            usuario usu = new usuario();
            UsuarioControlador u = new UsuarioControlador();
            usu = u.findUserByRut(TxtBusqueda.Text);

            TxtRut.Text = usu.rut;
            TxtNombre.Text = usu.nombre;
            TxtApellido.Text = usu.apellido;
            TxtTelefono.Text = usu.telefono;
            TxtCorreo.Text = usu.correo;
            TxtDireccion.Text = usu.direccion;
            DdlComunas.SelectedValue = usu.idComuna.ToString();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (BtnModificar.Text == "Modificar")
            {
                TxtCorreo.Enabled = true;
                TxtTelefono.Enabled = true;
                TxtDireccion.Enabled = true;
                DdlComunas.Enabled = true;
                BtnModificar.Text = "Guardar";
            }
            else if (BtnModificar.Text == "Guardar")
            {
                UsuarioControlador usu = new UsuarioControlador();
                usuario usua = new usuario();
                usua = usu.edithUsuEmp(TxtRut.Text, TxtCorreo.Text, TxtTelefono.Text, TxtDireccion.Text, int.Parse(DdlComunas.SelectedValue));
                BtnModificar.Text = "Modificar";
                TxtCorreo.Enabled = false;
                TxtTelefono.Enabled = false;
                TxtDireccion.Enabled = false;
                DdlComunas.Enabled = false;
            }
        }
    }
    
}