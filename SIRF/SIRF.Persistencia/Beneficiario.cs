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
    
    public partial class Beneficiario
    {
        public int beneficiarioID { get; set; }
        public int catSolicitudID { get; set; }
        public int identificadorTipo { get; set; }
        public int dependienteID { get; set; }
        public short catDependienteID { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string sexo { get; set; }
        public bool estatusLogico { get; set; }
        public Nullable<int> solicitudRecursoID { get; set; }
    
        public virtual CatDependiente CatDependiente { get; set; }
        public virtual CatSolicitud CatSolicitud { get; set; }
    }
}
