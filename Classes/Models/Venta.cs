//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Taller_AdminShop.Classes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Venta_detalle = new HashSet<Venta_detalle>();
        }
    
        public int id_venta { get; set; }
        public double total { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<byte> estado { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public int id_usuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_detalle> Venta_detalle { get; set; }
    }
}
