using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using reciclemos_v3.Controladores;
using reciclemos_v3.Modelo;
using reciclemos_v3.Clases;


namespace reciclemos_v3.PanelUsuario
{
    public partial class SolicitudesUsuario : System.Web.UI.Page
    {
        int idUsu = 0;
        List<Materiales> listaMateriales = new List<Materiales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                usuario u = (usuario)Session["Usuario"];
                idUsu = u.idUsuario;
            }

        }

        public void AddMat(TextBox txt)
        {
            if (int.Parse(txt.Text) > 0)
            {
                Materiales m = new Materiales();
                m.Nombre = txt.ID;
                m.Cantidad = int.Parse(txt.Text);
                m.IdMaterial = txt.TabIndex;
                listaMateriales.Add(m);
            }
        }

        protected void BtnSolicitud_Click(object sender, EventArgs e)
        {
            AddMat(PET);
            AddMat(PEBD);
            AddMat(PEAD);
            AddMat(PP);
            AddMat(PS);
            AddMat(Vidrio);
            AddMat(Lata);
            AddMat(Papel);
            AddMat(Aluminio);
            AddMat(Tetra);
            AddMat(Carton);

            LblMensaje.Text = SolicitudControlador.addSolicitud(idUsu, listaMateriales, 1, Convert.ToDateTime(TxtFecha.Text), DdlHorario.SelectedValue, TxtDescripcion.Text);
            
        }
    }
}