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
    
    public partial class Devolucione
    {
        public int DevolucionID { get; set; }
        public Nullable<int> ReservaID { get; set; }
        public Nullable<System.DateTime> FechaDevolucion { get; set; }
        public string Observaciones { get; set; }
        [JsonIgnore]
        public virtual Reserva Reserva { get; set; }
    }
}
