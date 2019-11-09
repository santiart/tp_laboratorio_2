using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using EntidadesAbstractas;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region Methods

        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            StreamWriter sw = new StreamWriter(archivo);
            if(!object.Equals(sw,null) && !object.Equals(datos,null))
            {
                sw.Write(datos);
                retorno = true;
            }
            else
            {
                throw new ArchivosException(new Exception());
            }
            sw.Close();

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;

            StreamReader sr;

            if(File.Exists(archivo))
            {
                sr = new StreamReader(archivo);
                datos = sr.ReadToEnd();
                sr.Close();
                retorno = true;
            }
            else
            {
                datos = String.Empty;
            }
            
            return retorno;

        }
        #endregion
    }
}
