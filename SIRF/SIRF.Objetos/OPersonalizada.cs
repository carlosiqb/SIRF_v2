using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OPersonalizada
    {
        public OPersonalizada() { }
        public OPersonalizada(OPersonalizada Pers)
        {
            ViaticoID = Pers.ViaticoID;
            NumeroExpediente = Pers.NumeroExpediente;
            CodPartida = Pers.CodPartida;
            Denominacion = Pers.Denominacion;
            paisID = Pers.paisID;
            DescripcionPais = Pers.DescripcionPais;
            EntidadFederativaID = Pers.EntidadFederativaID;
            DescripcionEntidadFederativa = Pers.DescripcionEntidadFederativa;
            MunicipioLocalidadID = Pers.MunicipioLocalidadID;
            DescripcionMunicipioLocalidad = Pers.DescripcionMunicipioLocalidad;
            DestinoID = Pers.DestinoID;
            DescripcionDestino = Pers.DescripcionDestino;
            NombreOperativo = Pers.NombreOperativo;
            ObjetivoComision = Pers.ObjetivoComision;
            FechaInicio = Pers.FechaInicio;
            FechaFin = Pers.FechaFin;
            DiasCompletos = Pers.DiasCompletos;
            DiasMedios = Pers.DiasMedios;
            MonedaID = Pers.MonedaID;
            DescripcionMoneda = Pers.DescripcionMoneda;
            ImporteOtorgado = Pers.ImporteOtorgado;

        }

        public int ViaticoID { get; set; }
        public string NumeroExpediente { get; set; }
        public string CodPartida { get; set; }
        public string Denominacion { get; set; }
        public string paisID { get; set; }
        public string DescripcionPais { get; set; }
        public string EntidadFederativaID { get; set; }
        public string DescripcionEntidadFederativa { get; set; }
        public string MunicipioLocalidadID { get; set; }
        public string DescripcionMunicipioLocalidad { get; set; }
        public string DestinoID { get; set; }
        public string DescripcionDestino { get; set; }
        public string NombreOperativo { get; set; }
        public string ObjetivoComision { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string DiasCompletos { get; set; }
        public string DiasMedios { get; set; }
        public string MonedaID { get; set; }
        public string DescripcionMoneda { get; set; }
        public string ImporteOtorgado { get; set; }

    }
}
