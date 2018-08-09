using SIRF.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Data;

namespace SIRF.Utilerias
{
    public class Utils
    {
        public static readonly string CuotasDiariasTableName = "cargaMasivaCuotasDiarias";
        public static List<int> ListaIdsPerfilAnalistas = new List<int> { 2, 5, 6, 12, 19 };

        public const int MoneyIntegerPositions = 12;
        public const int MoneyDecimalPositions = 2;
        public static readonly string RegExpMoneyAmounts = @"^\d{1," + MoneyIntegerPositions + @"}([.]\d{1," + MoneyDecimalPositions + "})?$";

        // cuando den la definición correcta,  ajustar las validaciones que se hacen en capa de negocio
        public static readonly string RegExpRFC = @"^[a-zA-Z&]{3,4}(\d{6})((\D|\d){3})?$"; // está mal, pero hasta que definan, se queda

        public static readonly string RegExpCLABE = @"^\s*([0-9]{18})\z";
        public static readonly string RegExpCuentaBancaria = @"^\s*([0-9]{10})\z";

        public static DateTime FechaActual = DateTime.Now;

        public const string Login = "Login";
        public const string formtaDateShort = "dd/MM/yyyy";
        public const string pesitos = "$ ";
        public const string COPA = "COPA";
        public const bool Verdadero = true;
        public const bool Falso = false;

        public const int BancoBBVA = 1;
        public const int BancoHSBC = 2;
        public const int NumeroOperacionesLimite = 401;


        public const string descripcionBancariaRegistrada = "Presion Registrada";
        public const string descripcionBancariaRechazada = "Presion No Autorizada";
        public const string descripcionBancariaSaldo = "Abono a Saldo";

        public const string optTipo = "optTipo";
        public const string optFecha = "optFecha";
        public const string optEstatus = "optEstatus";
        public const string optFolio = "optFolio";
        public const string optTodos = "optTodos";

        public const string Content = "contentBody";
        public const string AumentoSaldo = "Aumento Saldo";

        public const string PrioridadNormal = "NORMAL";
        public const string PrioridadAlta = "ALTA";

        public const string PrioridadNormalColor = "#00FF00";
        public const string PrioridadAltaColor = "#FF0000";

        public const int BancosOperacionesEspecificas = 12;
        public const int BancosIngresosyEgresos = 13;
        public const int DirectorBancos = 14;

        public const string BancoAreaIngresosReporte = "INGRESOS";
        public const string BancoAreaOperacionesEspecificasReporte = "OPERACIONES ESPECIFICAS";
        public const string BancoAreaIngresosFiltro = "Bancos IE";
        public const string BancoAreaOperacionesEspecificasFiltro = "Bancos OE";
        public const string parDia = "dia";
        public const string parMes = "mes";
        public const string parAnio = "anio";
        public const string parArea = "area";


        public const string solicitudID = "solicitudID";
        public const string Informacion = "Informacion";
        public const string SolicitudActualizada = "La Solicitud ha sido actuliazada correctamente";
        public const string Exito = "Éxito";

        public static class MensajesMovimiento
        {
            public const string LayoutRadicacionRechazado = "Radicacion";
            public const string CoprobanteDePagoRechazado = "Comprobante";
            public const string LayoutTransferenciaRechazado = "Transferencias";
        }

        public static string ObtenerMesLetra(int mes)
        {
            string result = string.Empty;
            switch (mes)
            {
                case 1:
                    result = "ENERO";
                    break;
                case 2:
                    result = "FEBRERO";
                    break;
                case 3:
                    result = "MARZO";
                    break;
                case 4:
                    result = "ABRIL";
                    break;
                case 5:
                    result = "MAYO";
                    break;
                case 6:
                    result = "JUNIO";
                    break;
                case 7:
                    result = "JULIO";
                    break;
                case 8:
                    result = "AGOSTO";
                    break;
                case 9:
                    result = "SEPTIEMBRE";
                    break;
                case 10:
                    result = "OCTUBRE";
                    break;
                case 11:
                    result = "NOVIEMBRE";
                    break;
                case 12:
                    result = "DICIEMBRE";
                    break;
                default:
                    break;
            }
            return result;
        }

        public static string FormateaNombre(string nombre)
        {
            var nombreRegreso = string.Empty;
            var espacio = ' ';
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrWhiteSpace(nombre))
            {
                nombre = nombre.Trim();
                var lista = nombre.Split(espacio);
                foreach (var parte in lista)
                {
                    if (!string.IsNullOrEmpty(parte) && !string.IsNullOrWhiteSpace(parte))
                    {
                        nombreRegreso += parte + espacio;
                    }
                }
            }
            return nombreRegreso.Trim();
        }

        public static bool ValidaSoloLetrasYCaracteresEspecialesOpcional(string texto, string caracteresEspeciales)
        {
            var result = false;
            string pattern = @"^[A-Za-zÁÉÍÓÚaáéíóúÄËÏÖÜäëïöüÇçÑñ" + caracteresEspeciales + @"]+$";
            Regex regex = new Regex(pattern);

            result = regex.IsMatch(texto);

            return result;
        }

        public static bool ValidaSoloLetrasYEspacios(string texto)
        {
            var result = false;
            string pattern = @"^[A-Za-zÁÉÍÓÚaáéíóúÄËÏÖÜäëïöüÇçÑñ \s]+$";
            Regex regex = new Regex(pattern);

            result = regex.IsMatch(texto);

            return result;
        }

        public static bool ValidaCarateresEspeciales(string texto)
        {
            var result = false;
            string pattern = @"^[a-zA-Z0-9 \/-]+$";
            Regex regex = new Regex(pattern);

            result = regex.IsMatch(texto);

            return result;
        }

        /// <summary>
        /// Valida el Numero de Oficio capturado
        /// </summary>
        /// <param name="numOficio">Numero de Oficio capturado</param>
        /// <returns>Si contiene solo letras, numeros, / y -</returns>
        public static bool ValidaNumeroOficio(string numOficio)
        {
            var result = false;
            string pattern = @"^[A-Z0-9\/]+$";
            Regex regex = new Regex(pattern);

            result = regex.IsMatch(numOficio);
            return result;
        }

        public static string GetInnerExceptionDescription(Exception ex)
        {
            if (null == ex.InnerException)
            {
                return Environment.NewLine + ex.Message;
            }
            else
            {
                return GetInnerExceptionDescription(ex.InnerException);
            }
        }

        public static bool ValidateMoney(decimal amount)
        {
            try
            {
                var strTempAmount = decimal.Parse(amount.ToString()).ToString("G29");

                return Regex.IsMatch(strTempAmount, RegExpMoneyAmounts);
            }
            catch (Exception ex)
            {
                throw new Exception(GetInnerExceptionDescription(ex));
            }
        }

        public static bool ValidateRFC(string rfc, ref string strErrMsg)
        {
            var result = true;
            strErrMsg += Environment.NewLine;
            var RegExpRfcNombre = @"^[A-Z]{4}?$";

            try
            {
                var upRfc = rfc.ToUpper().Trim();
                var strNombre = new String(upRfc.Take(4).ToArray());
                var strAnio = new String(upRfc.Skip(4).Take(2).ToArray());
                var strMes = new String(upRfc.Skip(6).Take(2).ToArray());
                var strDia = new String(upRfc.Skip(8).Take(2).ToArray());

                if (!Regex.IsMatch(strNombre, RegExpRfcNombre))
                {
                    result = false;
                    strErrMsg += string.Format("Los primeros 4 caracteres, no son letras: {0}", strNombre) + Environment.NewLine;
                }

                int intAnio;
                if (!int.TryParse(strAnio, out intAnio))
                {
                    result = false;
                    strErrMsg += string.Format("El año no es válido: {0}", strAnio) + Environment.NewLine;
                }

                int intMes;
                if (!int.TryParse(strMes, out intMes))
                {
                    result = false;
                    strErrMsg += string.Format("El mes no es válido: {0}", strMes) + Environment.NewLine;
                }
                else
                {
                    if (intMes < 1 || intMes > 12)
                    {
                        result = false;
                        strErrMsg += string.Format("El mes no es válido: {0}", strMes) + Environment.NewLine;
                    }
                }

                int intDia;
                if (!int.TryParse(strDia, out intDia))
                {
                    result = false;
                    strErrMsg += string.Format("El día no es válido: {0}", strDia) + Environment.NewLine;
                }
                else
                {
                    if (intDia < 1 || intDia > 31)
                    {
                        result = false;
                        strErrMsg += string.Format("El día no es válido: {0}", strDia) + Environment.NewLine;
                    }
                }

                if (rfc.Length == 10)
                {
                    result = result && true;
                }
                else if (rfc.Length == 13)
                {
                    var RegExpRFCHomo = @"^[A-Z0-9]{3}?$";
                    var strHomo = new String(upRfc.Skip(10).Take(3).ToArray());
                    if (!Regex.IsMatch(strHomo, RegExpRFCHomo))
                    {
                        result = false;
                        strErrMsg += string.Format("La homoclave no es válida: {0}", strHomo) + Environment.NewLine;
                    }
                }
                else
                {
                    strErrMsg += string.Format("La longitud no es válida: {0}", upRfc.Length) + Environment.NewLine;
                    result = false;
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(GetInnerExceptionDescription(ex));
                strErrMsg = GetInnerExceptionDescription(ex);
            }
            return result;
        }

        public static bool ValidateCLABE(string clabe)
        {
            try
            {
                return Regex.IsMatch(clabe, RegExpCLABE);
            }
            catch (Exception ex)
            {
                throw new Exception(GetInnerExceptionDescription(ex));
            }
        }

        public static bool ValidateCuentaBancaria(string cuenta)
        {
            try
            {
                return Regex.IsMatch(cuenta, RegExpCuentaBancaria);
            }
            catch (Exception ex)
            {
                throw new Exception(GetInnerExceptionDescription(ex));
            }
        }

        public static int GenerateUniqueId()
        {
            Thread.Sleep(1);
            DateTime generator = DateTime.Now;
            int mils = generator.Millisecond;
            int secs = generator.Second * 1000;
            int mins = generator.Minute * 100000;
            int hrs = generator.Hour * 1000000;
            int days = generator.Day * 10000000;
            int uniqueId = days + hrs + mins + secs + mils;

            return uniqueId;
        }

        public static String PadString(String cadena, char relleno, int longitud, bool alinearDerecha)
        {
            String complemento;
            string aux;
            complemento = new String(relleno, longitud);

            if (alinearDerecha)
            {
                aux = complemento + cadena;
                aux = aux.Substring(aux.Length - longitud, longitud);
            }
            else
            {
                aux = cadena + complemento;
                aux = aux.Substring(0, longitud);
            }
            return aux;
        }
    }

    //public static class ExcelUtils
    //{
    //    public static DataTable ToDataTable(this ExcelPackage package, string strFileName, Dictionary<string, string> parametrosControl, List<string> listaColumnas)
    //    {
    //        var table = new DataTable();
    //        var numRegistro = 0;
    //        var controlColumnsNumber = parametrosControl.Count;

    //        try
    //        {
    //            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();

    //            foreach (var param in parametrosControl)
    //            {
    //                table.Columns.Add(param.Key);
    //            }
    //            table.Columns.Add(ParametrosValidacionCargaMasiva.NumRegistro);

    //            foreach (var firstRowCell in workSheet.Cells[1, 1, 1, workSheet.Dimension.End.Column])
    //            {
    //                if (!listaColumnas.Contains(firstRowCell.Text.Trim()))
    //                {
    //                    throw new Exception("Plantilla no válida");
    //                }
    //                else
    //                {
    //                    table.Columns.Add(firstRowCell.Text.Trim());
    //                }
    //            }

    //            for (var rowNumber = 2; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
    //            {
    //                numRegistro++;
    //                var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
    //                var newRow = table.NewRow();

    //                var rowIndex = 0;
    //                foreach (var param in parametrosControl)
    //                {
    //                    newRow[rowIndex] = param.Value;
    //                    newRow[controlColumnsNumber] = numRegistro;
    //                    rowIndex++;
    //                }

    //                foreach (var cell in row)
    //                {
    //                    newRow[controlColumnsNumber + cell.Start.Column] = cell.Text;
    //                }
    //                table.Rows.Add(newRow);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            var strErrMsg = Util.GetInnerExceptionDescription(ex);
    //            if (strErrMsg.ToUpper().Contains("COLUMN"))
    //            {
    //                strErrMsg += " para el registro: " + numRegistro;
    //            }
    //            throw new Exception(strErrMsg);
    //        }

    //        return table;
    //    }

    //}

    // vjps: 29062017
    public class Range<T>
    {
        public readonly T Start;
        public readonly T End;

        public Range(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }
    }

    public static class Range
    {
        public static bool Overlap<T>(Range<T> left, Range<T> right)
            where T : IComparable<T>
        {
            bool result = false;

            if (left.Start.CompareTo(right.Start) == 0)
            {
                result = true;
            }
            else if (left.Start.CompareTo(right.Start) > 0)
            {
                result = left.Start.CompareTo(right.End) <= 0;
            }
            else
            {
                result = right.Start.CompareTo(left.End) <= 0;
            }
            return result;
        }
    }


}
