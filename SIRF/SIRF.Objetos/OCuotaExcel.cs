using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OCuotaDiaria
    /// </summary>
    [Serializable]
    public class OCuotaExcel
    {
        public int indice;
        public string NumeroExpediente { get; set; }
        public string Concepto { get; set; }
        public string Partida { get; set; }
        public string FormaPago { get; set; }
        public string CuotaDiaria { get; set; }
        public string An_o { get; set; }
        public string Mes { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public string Lugar { get; set; }

        public string errores { get; set; }

        public bool b_NumeroExpediente { get; set; }
        public bool b_Concepto { get; set; }
        public bool b_Partida { get; set; }
        public bool b_FormaPago { get; set; }
        public bool b_CuotaDiaria { get; set; }
        public bool b_Inicio { get; set; }
        public bool b_Fin { get; set; }
        public bool b_Lugar { get; set; }

        public int c_NumeroExpediente { get; set; }
        public int c_Concepto { get; set; }
        public int c_Partida { get; set; }
        public int c_FormaPago { get; set; }
        public bool c_CuotaDiaria { get; set; }
        public bool c_Inicio { get; set; }
        public bool c_Fin { get; set; }
        public bool c_Lugar { get; set; }
        public string c_CLABE { get; set; }
        public string c_CuentaBancaria { get; set; }

        public int c_Banco { get; set; }
    }
}