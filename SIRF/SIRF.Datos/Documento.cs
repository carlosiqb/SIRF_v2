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
    
    public partial class Documento
    {
        public int documentoID { get; set; }
        public Nullable<int> solicitudRecursoID { get; set; }
        public Nullable<int> catDocumentoID { get; set; }
        public string descripcionDocumento { get; set; }
        public string anexo { get; set; }
        public Nullable<System.DateTime> fechaRecepcion { get; set; }
        public bool estatus { get; set; }
        public string extensionDocumento { get; set; }
        public byte[] contenido { get; set; }
    
        public virtual CatDocumento CatDocumento { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
