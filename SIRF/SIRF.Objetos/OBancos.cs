using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OBancos
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int bancoID { get; set; }
        /// <summary>
        /// Clave Banco
        /// </summary>
        public string cveBanco { get; set; }
        /// <summary>
        /// Descripcion Banco
        /// </summary>
        public string descripcionBanco { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
