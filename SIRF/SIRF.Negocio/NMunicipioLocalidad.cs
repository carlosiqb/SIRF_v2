using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    public class NMunicipioLocalidad : Instance<NMunicipioLocalidad>
    {
        /// <summary>
        /// Consulta catálogo : Author JUVA
        /// </summary>
        /// <returns>Municipios</returns>
        public List<OMunicipioLocalidad> ObtenerLista()
        {
            DMunicipioLocalidad municipioLocalidad = new DMunicipioLocalidad();
            return municipioLocalidad.ObtenerLista();
        }
    }
}
