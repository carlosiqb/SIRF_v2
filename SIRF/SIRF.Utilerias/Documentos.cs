using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Utilerias
{
    /// <summary>
    /// Utilerias para Documentos
    /// </summary>
    public class Documentos : Instance<Documentos>
    {
        /// <summary>
        /// Método para la codificación del archivo a guardar en base de datos.
        /// </summary>
        /// <param name="sNombreArchivo">Ruta y Nombre del archivo</param>
        /// <returns>arreglo de bytes</returns>
        public byte[] CodificarArchivo(string sNombreArchivo)
        {
            string sBase64 = "";
            // Declaramos fs para tener acceso al archivo residente en la maquina cliente.
            FileStream fs = new FileStream(sNombreArchivo, FileMode.Open);
            // Declaramos un Leector Binario para accesar a los datos del archivo pasarlos a un arreglo de bytes
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = new byte[(int)fs.Length];
            try
            {
                br.Read(bytes, 0, bytes.Length);
                // base64 es la cadena en donde se guarda el arreglo de bytes ya convertido
                //sBase64 = Convert.ToBase64String(bytes);
                return bytes;
            }

            catch(Exception ex)
            {
                //MessageBox.Show("Ocurri un error al cargar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return null;
            }
            // Se cierran los archivos para liberar memoria.
            finally
            {
                fs.Close();
                fs = null;
                br = null;
                //bytes = null;
            }
        }
        /// <summary>
        /// Método para la decodificación del archivo a guardado en base de datos.
        /// </summary>
        /// <param name="sBase64">Archivo guardado en base datos</param>
        /// <returns></returns>
        public string DecodificarArchivo(string sBase64)
        {
            // Declaramos fs para tener crear un nuevo archivo temporal en la maquina cliente.
            // y memStream para almacenar en memoria la cadena recibida.
            string sImagenTemporal = @"c:PRUEBA.mp3";  //Nombre del archivo y su extencion
            FileStream fs = new FileStream(sImagenTemporal, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            byte[] bytes;
            try
            {
                bytes = Convert.FromBase64String(sBase64);
                bw.Write(bytes);
                return sImagenTemporal;
            }
            catch
            {
                //MessageBox.Show("Ocurrió un error al leer la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return sImagenTemporal = @"c:PRUEBA.MP3";
            }
            finally
            {
                fs.Close();
                bytes = null;
                bw = null;
                sBase64 = null;
            }
        }
    }
}










//byte[] image;

//using (BinaryReader reader = new BinaryReader(uploaded_file.PostedFile.InputStream))
//{
//    image = reader.ReadBytes(uploaded_file.PostedFile.ContentLength);
//}