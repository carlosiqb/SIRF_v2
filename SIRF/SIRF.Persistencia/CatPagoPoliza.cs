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
    
    public partial class CatPagoPoliza
    {
        public CatPagoPoliza()
        {
            this.PolizaPago = new HashSet<PolizaPago>();
        }
    
        public short catPagoPolizaID { get; set; }
        public string descripcioon { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<PolizaPago> PolizaPago { get; set; }
    }
}
