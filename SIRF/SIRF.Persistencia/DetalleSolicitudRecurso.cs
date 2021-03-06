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
    
    public partial class DetalleSolicitudRecurso
    {
        public DetalleSolicitudRecurso()
        {
            this.LugarSolicitudRecurso = new HashSet<LugarSolicitudRecurso>();
            this.PartidaSolicitudRecurso = new HashSet<PartidaSolicitudRecurso>();
        }
    
        public int detalleSolicitudRecursoID { get; set; }
        public int solicitudRecursoID { get; set; }
        public Nullable<int> homologadoID { get; set; }
        public string nombreOperativo { get; set; }
        public string objetivoComision { get; set; }
        public string numeroExpediente { get; set; }
        public bool estatusHomologado { get; set; }
        public string clabeInterbancaria { get; set; }
        public string cuentaBancaria { get; set; }
        public short cuenta { get; set; }
        public bool estatusLogico { get; set; }
        public int catBancoID { get; set; }
        public string numeroTarjeta { get; set; }
        public byte[] ComprobanteOtraCuenta { get; set; }
    
        public virtual CatBanco CatBanco { get; set; }
        public virtual ICollection<LugarSolicitudRecurso> LugarSolicitudRecurso { get; set; }
        public virtual ICollection<PartidaSolicitudRecurso> PartidaSolicitudRecurso { get; set; }
        public virtual Homologado Homologado { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
