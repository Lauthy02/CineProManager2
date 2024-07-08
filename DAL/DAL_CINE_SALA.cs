using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CINE_SALA
    {
        internal DAL_ACCESOBD acceso;

        public DAL_CINE_SALA()
        {
            acceso = new DAL_ACCESOBD();
            acceso.AbrirConexion();
        }

        public int Alta(BE_CINE cine, BE_SALA sala)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idcine", cine.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idsala", sala.Id);
            parametros.Add(p);

            int res = acceso.Escribir("CINE_SALA_INSERTAR", parametros);
            //INSERT INTO CINE_SALA VALUES (@idcine, @idsala)
            return res;
        }
    }
}
