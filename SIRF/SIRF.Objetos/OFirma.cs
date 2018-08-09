using System;

namespace SIRF.Objetos
{
    [Serializable]
    public class OFirma
    {
        public int FirmaID { get; set; }
        public string Descripcion { get; set; }
        public bool? EstadoLogico { get; set; }
    }
}
