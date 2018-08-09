using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;
using SIRF.Mensajes;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente al catalogo de Moneda.
    /// </summary>
    public class NMoneda : Instance<NMoneda>
    {
        /// <summary>
        /// Consulta de catálogo : Author JUVA
        /// </summary>
        /// <returns>Monedas</returns>
        public List<OMoneda> ObtenerLista(string zonaMoneda)
        {
            DMoneda moneda = new DMoneda();
            return moneda.ObtenerLista(zonaMoneda);
        }
    }
}
