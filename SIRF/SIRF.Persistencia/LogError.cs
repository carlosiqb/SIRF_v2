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
    
    public partial class LogError
    {
        public int logErrorID { get; set; }
        public Nullable<int> usuarioID { get; set; }
        public string error { get; set; }
        public string formulario { get; set; }
        public string evento { get; set; }
        public System.DateTime fecha { get; set; }
        public string codigoError { get; set; }
        public string nombreEquipo { get; set; }
        public string ipEquipo { get; set; }
        public string stacktrace { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}