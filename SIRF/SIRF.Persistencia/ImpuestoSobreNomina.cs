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
    
    public partial class ImpuestoSobreNomina
    {
        public int impuestoSobreNominaID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catPartidaID { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public decimal importe { get; set; }
    
        public virtual CatPartida CatPartida { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
