using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Utilerias
{
    /// <summary>
    /// Clase para la carga de archivo mediante FTP
    /// </summary>
   public class ServicioFTP
    {
        private string _host = null;
        private string _usrFTP = null;
        private string _pswFTP = null;
        private FtpWebRequest _requestFTP = null;
        private FtpWebResponse _responseFTP = null;
        private Stream _streamFTP = null;
        private int _bufferSize = 2048;


        /// <summary>
        /// Constructor
        /// </summary>
        public ServicioFTP(string domFTP, string usrFTP, string pwdFTP)
        {

            _host = domFTP;
            _usrFTP = usrFTP;
            _pswFTP = pwdFTP;
        }



        /// <summary>
        /// Obtien la lista de archivos en directorio FTP
        /// </summary>
        /// <param name="directorio">~\Directorio FTP</param>
        /// <returns>Archivos</returns>
        public List<string> ListadoArchivos(string directorio)
        {

            List<string> lstArchivos = new List<string>();
            StreamReader ftpReader = null;

            try
            {
                _requestFTP = (FtpWebRequest)FtpWebRequest.Create(_host + "/" + directorio);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                _responseFTP = (FtpWebResponse)_requestFTP.GetResponse();
                _streamFTP = _responseFTP.GetResponseStream();
                ftpReader = new StreamReader(_streamFTP);

                while (ftpReader.Peek() != -1)
                    lstArchivos.Add(ftpReader.ReadLine());
            }
            catch
            {
                //Implementar validación
            }
            finally
            {
                ftpReader.Close();
                _streamFTP.Close();
                _responseFTP.Close();
                _requestFTP = null;
            }

            return lstArchivos;
        }

        /// <summary>
        /// Envía respaldo de archivo a FTP
        /// </summary>
        /// <param name="archivoDestino">~\Archivo FTP</param>
        /// <param name="archivoOrigen">~\Archivo LOCAL</param>
        /// <returns></returns>
        public string ImportarArchivo(string archivoDestino, string archivoOrigen)
        {
            string resultado = string.Empty;
            FileStream localFileStream = null;

            try
            {

                _requestFTP = (FtpWebRequest)FtpWebRequest.Create(_host + "/" + archivoDestino);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.UploadFile;
                _streamFTP = _requestFTP.GetRequestStream();

                localFileStream = new FileStream(archivoOrigen, FileMode.Create);

                byte[] byteBuffer = new byte[_bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, _bufferSize);

                while (bytesSent != 0)
                {
                    _streamFTP.Write(byteBuffer, 0, bytesSent);
                    bytesSent = localFileStream.Read(byteBuffer, 0, _bufferSize);
                }
            }
            catch
            {
                //Implementar validación
            }
            finally
            {
                localFileStream.Close();
                _streamFTP.Close();
                _requestFTP = null;
            }

            return resultado;
        }

        /// <summary>
        /// Descarga archivo del servidor FTP 
        /// </summary>
        /// <param name="archivoOrigen">~\Archivo FTP</param>
        /// <param name="archivoDestino">~\Respaldo local</param>
        public void ExportarArchivo(string archivoOrigen, string archivoDestino)
        {
            FileStream localFileStream = null;

            try
            {
                _requestFTP = (FtpWebRequest)FtpWebRequest.Create(_host + "/" + archivoOrigen);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                _responseFTP = (FtpWebResponse)_requestFTP.GetResponse();
                _streamFTP = _responseFTP.GetResponseStream();

                localFileStream = new FileStream(archivoDestino, FileMode.Create);
                byte[] byteBuffer = new byte[_bufferSize];
                int bytesRead = _streamFTP.Read(byteBuffer, 0, _bufferSize);

                while (bytesRead > 0)
                {
                    localFileStream.Write(byteBuffer, 0, bytesRead);
                    bytesRead = _streamFTP.Read(byteBuffer, 0, _bufferSize);
                }
            }
            catch
            {
                //Implementar validación
            }
            finally
            {
                localFileStream.Close();
                _streamFTP.Close();
                _responseFTP.Close();
                _requestFTP = null;
            }
        }

        /// <summary>
        /// Elimina archivo de FTP
        /// </summary>
        /// <param name="archivo">~\Archivo FTP</param>
        public void EliminarArchivo(string archivo)
        {
            try
            {
                _requestFTP = (FtpWebRequest)WebRequest.Create(_host + "/" + archivo);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                _responseFTP = (FtpWebResponse)_requestFTP.GetResponse();
            }
            catch
            {
                //Manejar excepción
            }
            finally
            {
                _responseFTP.Close();
                _requestFTP = null;
            }
        }

        /// <summary>
        /// Renombrar archivo de FTP
        /// </summary>
        /// <param name="archivoFTP">~\Archivo FTP</param>
        /// <param name="nuevoNombreArchivo">Nuevo nombre para archivo</param>
        public void RenombrarArchivo(string archivoFTP, string nuevoNombreArchivo)
        {
            try
            {
                _requestFTP = (FtpWebRequest)WebRequest.Create(_host + "/" + archivoFTP);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.Rename;
                _requestFTP.RenameTo = nuevoNombreArchivo;
                _responseFTP = (FtpWebResponse)_requestFTP.GetResponse();
            }
            catch
            {
                //Manejar excepción
            }
            finally
            {
                _responseFTP.Close();
                _requestFTP = null;
            }
        }

        /// <summary>
        /// Crea carpeta en servidor FTP
        /// </summary>
        /// <param name="nuevaCarpeta">~\Carpeta</param>
        public void CrearCarpeta(string nuevaCarpeta)
        {
            try
            {
                _requestFTP = (FtpWebRequest)WebRequest.Create(_host + "/" + nuevaCarpeta);
                _requestFTP.Credentials = new NetworkCredential(_usrFTP, _pswFTP);
                _requestFTP.UseBinary = true;
                _requestFTP.UsePassive = true;
                _requestFTP.KeepAlive = true;
                _requestFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                _responseFTP = (FtpWebResponse)_requestFTP.GetResponse();
            }
            catch(Exception ex)
            {
                //Si no existe la carpeta no hacer nada
            }
            finally
            {
                _responseFTP.Close();
                _requestFTP = null;
            }
        }

    }
}