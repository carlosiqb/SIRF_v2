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
    
    public partial class SolicitudFirma
    {
        public int solicitudFirmaID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catFirmaID { get; set; }
        public int estatusID { get; set; }
        public System.DateTime FechaFirma { get; set; }
        public Nullable<bool> EstatusLogico { get; set; }
    
        public virtual CatFirma CatFirma { get; set; }
        public virtual SolicitudFirma SolicitudFirma1 { get; set; }
        public virtual SolicitudFirma SolicitudFirma2 { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}