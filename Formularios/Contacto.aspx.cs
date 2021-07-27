using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Modelo;
using reciclemos_v3.Controladores;
using System.Drawing;

namespace reciclemos_v3.Formularios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            MensajeControlador msn = new MensajeControlador();
            int idEstado = 1;
            LblMensaje.Text = msn.addProspecto(TxtNom.Text, TxtCorr.Text, TxtTel.Text,TxtArea.Text, idEstado);
            LblMensaje.ForeColor = Color.Green;
            if (LblMensaje.Text.Equals("Mensaje enviado"))
            {
                TxtNom.Text = "";
                TxtCorr.Text = "";
                TxtTel.Text = "";
                TxtArea.Text = "";
            }
        }
    }
}