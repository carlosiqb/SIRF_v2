using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    public class NDestino : Instance<NDestino>
    {
        /// <summary>
        /// Consulta catálogo
        /// </summary>
        /// <param name="entidadFederativaID">Filtrado por entidad federativa</param>
        /// <returns>Destinos</returns>
        public List<ODestino> ObtenerLista(int? entidadFederativaID)
        {
            DDestino destino = new DDestino();
            return destino.ObtenerLista(entidadFederativaID);
        }
    }
}
