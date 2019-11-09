using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using EntidadesAbstractas;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            if(!ReferenceEquals(datos, null))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));

                    TextWriter tw = new StreamWriter(archivo);
                    xml.Serialize(tw, datos);
                    tw.Close();
                    retorno = true;
                }
                catch(Exception e)
                {
                    throw new ArchivosException(e);
                }
            }
            else
            {
                throw new NullReferenceException();
            }

            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            if (File.Exists(archivo))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T)); 
                TextReader tr = new StreamReader(archivo);

                datos = (T)xml.Deserialize(tr);
                tr.Close();
                retorno = true;
            }
            else
                datos = default(T);
            return retorno;
        }
    }
}
