using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente al catalogo de Paises.
    /// </summary>
    public class NPaises : Instance<NPaises>
    {
        /// <summary>
        /// Consultar catálogo : Author 
        /// </summary>
        /// <param name="soloActivos">Filtro</param>
        /// <param name="zonaPais">Filtro</param>
        /// <returns>Paises</returns>
        public List<OPaises> ObtenerLista(bool soloActivos = false, string zonaPais = "Todos")
        {
            DPaises pais = new DPaises();
            return pais.ObtenerLista(soloActivos, zonaPais);
        }
    }
}
