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
    
    public partial class CargaCuotaDiaria
    {
        public int cargaCuotaDiariaID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catConceptoGastoID { get; set; }
        public Nullable<bool> estatusLogico { get; set; }
        public Nullable<System.DateTime> fechaCarga { get; set; }
        public Nullable<int> usuarioID { get; set; }
    
        public virtual CatConceptoGasto CatConceptoGasto { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
