//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRF.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class EstatusMovimiento
    {
        public int estatusMovimientoID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int usuarioID { get; set; }
        public System.DateTime fechaMovimiento { get; set; }
        public string observaciones { get; set; }
        public string movimiento { get; set; }
        public string modulo { get; set; }
    
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}