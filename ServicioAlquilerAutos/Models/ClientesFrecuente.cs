//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioAlquilerAutos.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class ClientesFrecuente
    {
        public int ClienteFrecuenteID { get; set; }
        public Nullable<int> Cedula { get; set; }
        public Nullable<decimal> DescuentoAplicado { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
    }
}
