using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OPartida
    /// </summary>
    [Serializable]
    public class OPartida
    {
        /// <summary>
        /// Identificador de la partida
        /// </summary>
        public int CodPartida { get; set; }
        /// <summary>
        /// Partida descripción
        /// </summary>
        public string DescripcionPartida { get; set; }
        /// <summary>
        /// Capítulo
        /// </summary>
        public int Capitulo { get; set; }
        /// <summary>
        /// Concepto
        /// </summary>
        public int? Concepto { get; set; }
        /// <summary>
        /// Denominación
        /// </summary>
        private string _denominacion;
        public string Denominacion
        {
            get
            {
                return CodPartida == -1 ?
                        _denominacion : CodPartida.ToString() + " " + _denominacion;
            }
            set
            {
                _denominacion = value;
            }
        }

        public string DenominacionGrid
        {
            get
            {
                return CodPartida == -1 ?
                        _denominacion : ((_denominacion.ToString() + " ").IndexOf(CodPartida.ToString()) >= 0 ? "" : (CodPartida.ToString() + " ")) + _denominacion;
            }
            set
            {
                _denominacion = value;
            }
        }

        public string ConceptoGtoCorriente { get; set; }

        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }

    [Serializable]
    public class PartidaObligatoriaModelo
    {
        public int PartidaObligatoriaID { get; set; }
        public int CodPartida { get; set; }
        public bool EstatusLogico { get; set; }
    }
}
