//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO_PROGRA_GRUPO3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURACION()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
        }
    
        public int ID_FACTURA { get; set; }
        public int PRECIO_TOTAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
    }
}
