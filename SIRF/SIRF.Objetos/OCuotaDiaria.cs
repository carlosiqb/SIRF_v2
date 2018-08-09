using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OCuotaDiaria
    /// </summary>
    [Serializable]
    public class OCuotaDiaria : ITipoSolicitud
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ITipoSolicitud Set()
        {
            return this;
        }

        /// <summary>
        /// Identificador
        /// </summary>
        public int CuotaDiariaID { get; set; }
        /// <summary>
        /// Catálogo  CatTipoCuotas
        /// </summary>
        public OTipoCuota TipoCuota { get; set; }
        /// <summary>
        /// Catálogo CatPartida
        /// </summary>
        public OPartida Partida { get; set; }
        /// <summary>
        /// Numero de dias efectivos
        /// </summary>
        public int NumeroDiasEfectivos { get; set; }
        /// <summary>
        /// MOnto apagar
        /// </summary>
        public decimal MontoPagar { get; set; }
        /// <summary>
        /// Numero de expediente
        /// </summary>
        public string NumeroExpediente { get; set; }
        /// <summary>
        /// Fecha inicial del periodo de pago
        /// </summary>
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Fecha final del periodo de pago
        /// </summary>
        public DateTime FechaFin { get; set; }
        /// <summary>
        /// Institución bancaria
        /// </summary>
        public string InstitucionBancaria { get; set; }
        /// <summary>
        /// Tipo de cuenta
        /// </summary>
        public short Cuenta { get; set; }
        /// <summary>
        /// Cuenta bancaria
        /// </summary>
        public string CuentaBancaria { get; set; }
        /// <summary>
        /// CLABE Interbancaria
        /// </summary>
        public string CLABEInterbancaria { get; set; }
        /// <summary>
        /// Edición de la cuota
        /// </summary>
        public bool SoloLectura { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public OCuotaDiaria()
        {
            TipoCuota = new OTipoCuota();
            Partida = new OPartida();
        }
    }
}