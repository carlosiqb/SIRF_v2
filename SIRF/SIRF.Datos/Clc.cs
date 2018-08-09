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
    
    public partial class Clc
    {
        public Clc()
        {
            this.PresupuestoClc = new HashSet<PresupuestoClc>();
        }
    
        public int clcID { get; set; }
        public string actividad { get; set; }
        public string mesServicio { get; set; }
        public Nullable<decimal> retencionCincoMillar { get; set; }
        public Nullable<decimal> retencionIVA { get; set; }
        public Nullable<decimal> retencionISR { get; set; }
        public Nullable<decimal> tipoCambioReferencial { get; set; }
        public Nullable<decimal> tipoCambioPago { get; set; }
        public Nullable<decimal> pagoMonedaExtranjera { get; set; }
        public Nullable<decimal> pagoPesos { get; set; }
        public int ejercicioFiscal { get; set; }
        public System.DateTime fechaPago { get; set; }
        public decimal suficienciaPresupuestal { get; set; }
        public decimal avisoReintegro { get; set; }
        public int anioServicio { get; set; }
        public decimal totalCLC { get; set; }
        public string numeroClc { get; set; }
        public decimal saldoFinal { get; set; }
        public decimal ejercicioCLC { get; set; }
    
        public virtual ICollection<PresupuestoClc> PresupuestoClc { get; set; }
    }
}
