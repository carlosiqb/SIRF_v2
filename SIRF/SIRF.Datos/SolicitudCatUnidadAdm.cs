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
    
    public partial class SolicitudCatUnidadAdm
    {
        public int solicitudCatUnidadAdmID { get; set; }
        public int catUnidadAdmID { get; set; }
        public int catSolicitudID { get; set; }
    
        public virtual CatSolicitud CatSolicitud { get; set; }
        public virtual CatUnidadAdm CatUnidadAdm { get; set; }
    }
}
