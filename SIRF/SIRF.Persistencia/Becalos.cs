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
    
    public partial class Becalos
    {
        public int becalosID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catPartidaID { get; set; }
        public decimal montoOtorgado { get; set; }
        public string titularCuentaBan { get; set; }
        public string cuentaBancaria { get; set; }
        public string institucionBancaria { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
        public string numeroExpediente { get; set; }
        public string clabeInterbancaria { get; set; }
    
        public virtual CatPartida CatPartida { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
