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
    /// Clase de negocio correspondiente al catalogo de Entidad Federativa.
    /// </summary>
    public class NEntidadFederativa : Instance<NEntidadFederativa>
    {
        public List<OEntidadFederativa> ObtenerLista(int codUA)
        {
            DEntidadFederativa entidadFederativa = new DEntidadFederativa();
            return entidadFederativa.ObtenerLista(codUA);
        }
    }
}
