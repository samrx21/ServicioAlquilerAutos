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
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.InventarioSucursals = new HashSet<InventarioSucursal>();
            this.Mantenimientoes = new HashSet<Mantenimiento>();
            this.Reservas = new HashSet<Reserva>();
        }
    
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Nullable<int> Anio { get; set; }
        public Nullable<decimal> TarifaPorDia { get; set; }
        public Nullable<int> CategoriaID { get; set; }

        [JsonIgnore]
        public virtual CategoriasVehiculo CategoriasVehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<InventarioSucursal> InventarioSucursals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Mantenimiento> Mantenimientoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
