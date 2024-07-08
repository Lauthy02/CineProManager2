using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ACCESOBD
    {
        private SqlConnection conexion;

        public void AbrirConexion()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-UMILLS4;Initial Catalog=CineProManagerTEST2;Integrated Security=SSPI");
            //String de conexion para la bd de la facu
            //conexion = new SqlConnection("Data Source=.;Initial Catalog=[nombre de la base];Integrated Security=SSPI");
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> args = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            if (args != null)
            {
                cmd.Parameters.AddRange(args.ToArray());
            }
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> args = null)
        {
            SqlCommand cmd = CrearComando(sql, args);
            int filAfec = 0;
            try
            {
                filAfec = cmd.ExecuteNonQuery();
            }
            catch
            {
                filAfec = -1;
            }
            return filAfec;
        }

        public DataTable Leer(string sql, List<SqlParameter> args = null)
        {
            DataTable tabla = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(CrearComando(sql, args)))
            {
                da.Fill(tabla);
                da.Dispose();
            }
            return tabla;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.String;
            return param;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.Int32;
            return param;
        }

        public SqlParameter CrearParametro(string nombre, byte[] valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            //No especifico el DbType para que el motor lo asigne de manera automática
            return param;
        }

        public SqlParameter CrearParametro(string nombre, DBNull dbnull)
        {
            SqlParameter param = new SqlParameter(nombre, dbnull);
            //No especifico el DbType para que el motor lo asigne de manera automática, ya que no se puede asignar un valor a un DBNull
            return param;
        }

        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.DateTime;
            return param;
        }
    }
}
