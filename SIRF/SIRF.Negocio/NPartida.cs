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
    /// Clase de negocio correspondiente al catalogo de las partidas.
    /// </summary>
    public class NPartida : Instance<NPartida>
    {
        /// <summary>
        /// Consultar catálogo : Author 
        /// </summary>
        /// <param name="soloActivos">Filtro</param>
        /// <param name="zonaPartidas">Filtro</param>
        /// <param name="tipoSolicitudID">Filtro opcional</param>
        /// <returns>Partidas</returns>
        public List<OPartida> ObtenerLista(int tipoSolicitudID, bool soloActivos = false, string zonaPartidas = "Todos")
        {
            DPartida partida = new DPartida();
            return partida.ObtenerLista(tipoSolicitudID, soloActivos, zonaPartidas);
        }
        /// <summary>
        /// Consultar catálogo : Author 
        /// </summary>
        /// <param name="soloActivos">Filtro</param>
        /// <param name="zonaPartidas">Filtro</param>
        /// <param name="tipoSolicitudID">Filtro opcional</param>
        /// <returns>Partidas</returns>
        public List<OPartida> ObtenerListaPasajes(int tipoSolicitudID, bool soloActivos = false, string zonaPasajes = "Todos")
        {
            DPartida partida = new DPartida();
            return partida.ObtenerListaPasajes(tipoSolicitudID, soloActivos, zonaPasajes);
        }
    }
}
