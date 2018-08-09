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
    
    public partial class GastoCorriente
    {
        public int gasCorrienteID { get; set; }
        public int solicitudRecursoID { get; set; }
        public int catConceptoPagoID { get; set; }
        public Nullable<int> catEntidadFederativaID { get; set; }
        public Nullable<int> catDetinoID { get; set; }
        public int catPartidaID { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public string numReciboPago { get; set; }
        public decimal montoSolicitado { get; set; }
    
        public virtual CatConceptoPago CatConceptoPago { get; set; }
        public virtual CatDestino CatDestino { get; set; }
        public virtual CatEntidadFederativa CatEntidadFederativa { get; set; }
        public virtual CatPartida CatPartida { get; set; }
        public virtual SolicitudRecurso SolicitudRecurso { get; set; }
    }
}
