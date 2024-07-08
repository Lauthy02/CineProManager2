using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SALA_FUNCION
    {
        internal DAL_ACCESOBD acceso;

        public DAL_SALA_FUNCION()
        {
            acceso = new DAL_ACCESOBD();
            acceso.AbrirConexion();
        }

        public int Alta(BE_SALA sala, BE_FUNCION funcion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idsala", sala.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idfuncion", funcion.Id);
            parametros.Add(p);

            int res = acceso.Escribir("SALA_FUNCION_INSERTAR", parametros);
            //INSERT INTO SALA_FUNCION VALUES (@idsala, @idfuncion)
            return res;
        }
    }
}
