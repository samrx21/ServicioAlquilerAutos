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
    
    public partial class Mantenimiento
    {
        public int MantenimientoID { get; set; }
        public string Placa { get; set; }
        public Nullable<System.DateTime> FechaMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Costo { get; set; }

        [JsonIgnore]
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
