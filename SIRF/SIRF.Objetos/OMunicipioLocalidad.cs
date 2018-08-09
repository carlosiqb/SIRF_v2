using System;

namespace SIRF.Objetos
{
    [Serializable]
    public class OMunicipioLocalidad
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int MunicipioLocalidadID { get; set; }
        /// <summary>
        /// Catálogo entidad federativa
        /// </summary>
        public OEntidadFederativa Entidad { get; set; }
        /// <summary>
        /// Municipio / Localidad
        /// </summary>
        public string DescripcionMunicipioLocalidad { get; set; }
        /// <summary>
        /// Más económico
        /// </summary>
        public bool MasEconomico { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
