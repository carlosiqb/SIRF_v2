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
    
    public partial class CatAgenciaAduanal
    {
        public CatAgenciaAduanal()
        {
            this.GastoAduana = new HashSet<GastoAduana>();
        }
    
        public int catAgenciaAduanalID { get; set; }
        public string descripcion { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<GastoAduana> GastoAduana { get; set; }
    }
}
