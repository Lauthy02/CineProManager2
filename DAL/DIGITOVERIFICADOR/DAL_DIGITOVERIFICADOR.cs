using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAL.DIGITOVERIFICADOR
{
    public class DAL_DIGITOVERIFICADOR
    {
        DAL_ENCRIPTADOR dalencriptador = new DAL_ENCRIPTADOR();

        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public DAL_DIGITOVERIFICADOR()
        {
            acceso.AbrirConexion();
        }

        public int CalcularDVH(string nombretabla)
        {
            /* 
            Este dígito se calcula para cada fila de la tabla y se almacena en la misma fila
            Este método recorre cada fila de la tabla y concatena los valores de las columnas (excepto la columna DigitoHorizontal). 
            Luego, calcula el hash SHA256 de la cadena concatenada y actualiza la fila con el nuevo DigitoHorizontal.
            Nota:
                SHA-256: Genera un hash de 256 bits (32 bytes). Cuando se representa en formato hexadecimal, 
                cada byte se convierte en dos caracteres hexadecimales, resultando en una cadena de 64 caracteres.
            */

            DataTable tabla = acceso.Leer($"SELECT * FROM {nombretabla}", null, false);
            //Uso esta manera y no el stored procedure porque el SQL no me deja usar el
            //parámetro @nombretabla (SELECT * FROM @nombretabla)

            int res = 0;
            string NombreCampo = "digitohorizontal";

            foreach (DataRow dr in tabla.Rows)
            {
                StringBuilder cadena = new StringBuilder();
                foreach (DataColumn columna in tabla.Columns)
                {
                    if (columna.ColumnName != NombreCampo)
                    {
                        cadena.Append(dr[columna].ToString());
                    }                    
                }

                string digitohorizontal = dalencriptador.EncriptarSHA256(cadena.ToString());

                res = acceso.Escribir($"UPDATE {nombretabla} SET digitohorizontal = '{digitohorizontal}' WHERE id = '{dr[0]}';", null, false);
            }
            return res;
        }

        public int CalcularDVV(string nombretabla)
        {
            /*
            Este dígito se calcula para toda la tabla y se almacena en una tabla separada
            Este método recorre cada fila de la tabla y concatena los valores de la columna DigitoHorizontal. 
            Luego, calcula el hash SHA256 de la cadena concatenada y devuelve el resultado
            */

            StringBuilder cadena = new StringBuilder();

            DataTable tabla = acceso.Leer($"SELECT * FROM {nombretabla}", null, false);
            //SELECT * FROM @nombretabla

            foreach (DataRow dr in tabla.Rows)
            {
                cadena.Append(dr["digitohorizontal"].ToString());
            }

            string digitovertical = dalencriptador.EncriptarSHA256(cadena.ToString());

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombretabla", nombretabla);
            parametros.Add(p);
            p = acceso.CrearParametro("@digitovertical", digitovertical);
            parametros.Add(p);

            int res = acceso.Escribir($"TABLA_DVV_INSERTAR", parametros);
            //INSERT INTO TABLA_DVV VALUES (@nombretabla, @digitovertical)

            return res;
        }
    }
}
