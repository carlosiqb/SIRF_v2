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
    
    public partial class CatRegion
    {
        public CatRegion()
        {
            this.CatUnidadAdm = new HashSet<CatUnidadAdm>();
            this.TipoSolicitudPorArea = new HashSet<TipoSolicitudPorArea>();
            this.UsuarioRegionFiscalizacion = new HashSet<UsuarioRegionFiscalizacion>();
        }
    
        public int regionID { get; set; }
        public string descripcion { get; set; }
        public string oficioRegion { get; set; }
        public bool estatusLogico { get; set; }
    
        public virtual ICollection<CatUnidadAdm> CatUnidadAdm { get; set; }
        public virtual ICollection<TipoSolicitudPorArea> TipoSolicitudPorArea { get; set; }
        public virtual ICollection<UsuarioRegionFiscalizacion> UsuarioRegionFiscalizacion { get; set; }
    }
}
