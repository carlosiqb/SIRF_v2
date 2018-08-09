using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRF.Objetos;

namespace SIRF.Utilerias
{
    /// <summary>
    /// Utilerias para Documentos
    /// </summary>
    public static class ConstruccionSelect
    {
        public static string GetSelect(List<OSelect> lista)
        {
            var cadenaSelect = "";
            foreach (var item in lista)
            {
                cadenaSelect+="<option value='"+item.Valor+"'>"+item.Concepto+"</option>";
            }
            return cadenaSelect;
        }
    }
}