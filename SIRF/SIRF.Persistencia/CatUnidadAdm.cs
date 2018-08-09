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
    
    public partial class CatUnidadAdm
    {
        public CatUnidadAdm()
        {
            this.AreaUnidadAdm = new HashSet<AreaUnidadAdm>();
            this.SolicitudCatUnidadAdm = new HashSet<SolicitudCatUnidadAdm>();
            this.SolicitudRecurso = new HashSet<SolicitudRecurso>();
            this.TipoSolicitudPorUA = new HashSet<TipoSolicitudPorUA>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int catUnidadAdmID { get; set; }
        public int catRegionID { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> codigoPadre { get; set; }
        public string abreviatura { get; set; }
        public bool estatusLogico { get; set; }
        public int catTipoUnidadAdmID { get; set; }
    
        public virtual CatRegion CatRegion { get; set; }
        public virtual ICollection<AreaUnidadAdm> AreaUnidadAdm { get; set; }
        public virtual ICollection<SolicitudCatUnidadAdm> SolicitudCatUnidadAdm { get; set; }
        public virtual ICollection<SolicitudRecurso> SolicitudRecurso { get; set; }
        public virtual ICollection<TipoSolicitudPorUA> TipoSolicitudPorUA { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}