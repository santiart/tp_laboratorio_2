using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;

            try
            {
                conexion.Open();
                comando.Connection = conexion;

                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = String.Format("INSERT INTO Paquetes(direccionEntrega,trackingId,alumno) values('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Santiago Aguado");

                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                    comando.Connection.Close();
            }

            return retorno;
        }

        static PaqueteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(Properties.Settings.Default.conexion);
        }
    }
}
