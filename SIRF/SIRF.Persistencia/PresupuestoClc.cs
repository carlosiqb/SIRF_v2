//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRF.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class PresupuestoClc
    {
        public int presupuestoClcID { get; set; }
        public Nullable<int> solicitudRecursoID { get; set; }
        public Nullable<int> clcID { get; set; }
        public decimal montoClc { get; set; }
    
        public virtual Clc Clc { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}