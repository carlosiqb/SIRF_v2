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
    
    public partial class RegistroContable
    {
        public int registroContableID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catTipoPolizaID { get; set; }
        public int consecutivo { get; set; }
        public string mes { get; set; }
        public System.DateTime fechaEmision { get; set; }
        public int anio { get; set; }
    
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
