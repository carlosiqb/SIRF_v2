using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OAccion 
    /// </summary>
    [Serializable]
    public class OMenu
    {
        public string lblNomUsuario { get; set; }
        public string accordion1 { get; set; }
        public string lblUnidadAdm { get; set; }
        public string lblDescripcionPerfil { get; set; }
        public string lblTipoRolUsuario { get; set; }
        public string hdfIPv4 { get; set; }
    }
}
