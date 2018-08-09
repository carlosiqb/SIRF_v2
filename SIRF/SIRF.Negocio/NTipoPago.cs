using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;
using SIRF.Mensajes;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente al catalogo de Bancos.
    /// </summary>
    public class NTipoPago : Instance<NTipoPago>
    {
        /// <summary>
        /// Consultar catálogo : Author 
        /// </summary>
        /// <param name="soloActivos">Filtro</param>
        /// <param name="TipoSolControlCod">Filtro</param>
        /// <returns>Paises</returns>
        public List<OTipoPago> ObtenerLista(bool soloActivos = false, int TipoSolControlCod = 0)
        {
            DTipoPago tipoPago = new DTipoPago();
            return tipoPago.ObtenerLista(soloActivos, TipoSolControlCod);
        }
    }
}
