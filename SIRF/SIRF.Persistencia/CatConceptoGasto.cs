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
    
    public partial class CatConceptoGasto
    {
        public CatConceptoGasto()
        {
            this.CargaCuotaDiaria = new HashSet<CargaCuotaDiaria>();
            this.Laudo = new HashSet<Laudo>();
        }
    
        public int catConceptoGastoID { get; set; }
        public string descripcion { get; set; }
        public int catSolicitudID { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<CargaCuotaDiaria> CargaCuotaDiaria { get; set; }
        public virtual CatSolicitud CatSolicitud { get; set; }
        public virtual ICollection<Laudo> Laudo { get; set; }
    }
}
