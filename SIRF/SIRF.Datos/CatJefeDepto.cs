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
    
    public partial class CatJefeDepto
    {
        public CatJefeDepto()
        {
            this.TipoJefeDepto = new HashSet<TipoJefeDepto>();
        }
    
        public int catJefeDeptoID { get; set; }
        public string claveTipoJefeDepto { get; set; }
        public string descripcionCorta { get; set; }
        public string descripcion { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<TipoJefeDepto> TipoJefeDepto { get; set; }
    }
}