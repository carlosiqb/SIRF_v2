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
    
    public partial class CatPrioridad
    {
        public CatPrioridad()
        {
            this.SolicitudRecurso = new HashSet<SolicitudRecurso>();
        }
    
        public int catPrioridadID { get; set; }
        public string descripcion { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<SolicitudRecurso> SolicitudRecurso { get; set; }
    }
}
