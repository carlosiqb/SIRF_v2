using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OExpedienteCuenta
    {
        /// <summary>
        /// Propiedad RegistroID
        /// </summary>
        public int RegistroID { get; set; }
        /// <summary>
        /// Propiedad CuentaIntegranteID
        /// </summary>
        public int CuentaIntegranteID { get; set; }
        /// <summary>
        /// Propiedad Expediente
        /// </summary>
        public int? Expediente { get; set; }
        /// <summary>
        /// Propiedad DescripcionCuenta
        /// </summary>
        public string DescripcionCuenta { get; set; }
        /// <summary>
        /// Propiedad CLABEInterbancaria
        /// </summary>
        public string CLABEInterbancaria { get; set; }
        /// <summary>
        /// Propiedad DescripcionBanco
        /// </summary>
        public string DescripcionBanco { get; set; }
        /// <summary>
        ///Propiedad TipoCuentaID
        /// </summary>
        public int TipoCuentaID { get; set; }
        /// <summary>
        /// Propiedad DescripcionTipoCuenta
        /// </summary>
        public string DescripcionTipoCuenta { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico
        /// </summary>
        public bool? EstatusLogico { get; set; }
    }
}
