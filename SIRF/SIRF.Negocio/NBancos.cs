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
    public class NBancos : Instance<NBancos>
    {
        /// <summary>
        /// Consultar catálogo : Author 
        /// </summary>
        /// <param name="soloActivos">Filtro</param>
        /// <returns>Paises</returns>
        public List<OBancos> ObtenerLista(bool soloActivos = false)
        {
            DBancos bancos = new DBancos();
            return bancos.ObtenerLista(soloActivos);
        }

        public int ObtenerBanco(string claveBanco)
        {
            DBancos bancos = new DBancos();
            return bancos.ObtenerBanco(claveBanco);
        }
    }
}
