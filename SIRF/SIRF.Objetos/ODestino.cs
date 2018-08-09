using System;

namespace SIRF.Objetos
{
    [Serializable]
    public class ODestino
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int? DestinoID { get; set; }
        /// <summary>
        /// Catálogo entidad federativa
        /// </summary>
        public OEntidadFederativa EntidadFederativa { get; set; }
        /// <summary>
        /// Destino
        /// <summary>
        public string DescripcionDestino { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
        /// <summary>
        /// Orden
        /// </summary>
        public int? Orden { get; set; }
    }
}
