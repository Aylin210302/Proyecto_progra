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
    
    public partial class PRODUCTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTOS()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.PROVEEDORES = new HashSet<PROVEEDORES>();
            this.PROVEEDORES1 = new HashSet<PROVEEDORES>();
        }
    
        public int ID_PRODUCTO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public int PRECIO_UNIDAD { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDORES> PROVEEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDORES> PROVEEDORES1 { get; set; }
    }
}
