using System;

namespace SIRF.Objetos
{
    [Serializable]
    public class OEntidadFederativa
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int? EntidadFederativaID { get; set; }
        /// <summary>
        /// Catálogo pais
        /// </summary>
        public OPaises Pais { get; set; }
        /// <summary>
        /// Entidad federativa
        /// </summary>
        public string DescripcionEntidadFederativa { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
