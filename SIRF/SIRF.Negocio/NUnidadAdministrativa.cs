using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente a la tabla UnidadAdministrativa.
    /// </summary>
    public class NUnidadAdministrativa : Instance<NUnidadAdministrativa>
    {
        /// <summary>
        /// Consulta catálogo : Author JUVA
        /// </summary>
        /// <param name="region"></param>
        /// <returns>Unidades administrativas</returns>
        public List<OUnidadAdministrativa> ObtenerLista(ORegion region)
        {
            DUnidadAdministrativa unidadAdministrativa = new DUnidadAdministrativa();
            return unidadAdministrativa.ObtenerLista(region);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public List<OUnidadAdministrativa> ObtenerListaPorRegionId(int regionId)
        {
            var unidadAdministrativa = new DUnidadAdministrativa();
            return unidadAdministrativa.ObtenerListaPorRegionId(regionId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codUA"></param>
        /// <returns></returns>
        public OUnidadAdministrativa ObtenerPorCodUA(int codUA)
        {
            var unidadAdministrativa = new DUnidadAdministrativa();
            return unidadAdministrativa.ObtenerPorCodUA(codUA);
        }
    }
}
