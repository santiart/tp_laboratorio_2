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

                comando.CommandText = String.Format("insert into Paquetes(direccionEntrega,trackingId,alumno) values('{0}','{1}', 'Aguado', 'Santiago')", p.DireccionEntrega, p.TrackingID);

                comando.Connection = conexion;

                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

            return retorno;
        }

        static PaqueteDAO()
        {
            comando = new SqlCommand(Properties.Settings.Default.conexion);
            conexion = new SqlConnection();
        }
    }
}
