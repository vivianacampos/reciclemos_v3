//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reciclemos_v3.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class prospecto
    {
        public int idProspecto { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string mensaje { get; set; }
        public Nullable<int> idEstado { get; set; }
    
        public virtual estado estado { get; set; }
    }
}
