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
    
    public partial class DETALLE_FACTURA
    {
        public int ID_FACTURA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int PRECIO_UNIDAD { get; set; }
        public string DESCRIPCION { get; set; }
        public int CANTIDAD { get; set; }
    
        public virtual FACTURACION FACTURACION { get; set; }
        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
