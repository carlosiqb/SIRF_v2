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
    
    public partial class EstatusPerfil
    {
        public int estatusPerfilID { get; set; }
        public int catPerfilID { get; set; }
        public short catEstatusSolicitudID { get; set; }
    
        public virtual CatEstatusSolicitud CatEstatusSolicitud { get; set; }
        public virtual CatPerfil CatPerfil { get; set; }
    }
}
