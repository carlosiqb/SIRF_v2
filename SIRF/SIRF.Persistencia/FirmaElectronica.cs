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
    
    public partial class FirmaElectronica
    {
        public int firmaElectronicaID { get; set; }
        public int solicitudRecursoID { get; set; }
        public string cadenaOriginalFirma { get; set; }
        public System.DateTime fecha { get; set; }
        public string folioTransaccion { get; set; }
        public string numeroTransaccion { get; set; }
    
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}