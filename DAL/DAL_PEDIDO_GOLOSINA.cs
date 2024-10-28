using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_PEDIDO_GOLOSINA
    {
        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public DAL_PEDIDO_GOLOSINA()
        {
            acceso.AbrirConexion();
        }

        public int Alta(BE_PEDIDO pedido, BE_GOLOSINA golosina, int cantidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idpedido", pedido.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idgolosina", golosina.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@cantidad", cantidad);
            parametros.Add(p);
            p = acceso.CrearParametro("@preciounitario", golosina.Precio);
            parametros.Add(p);

            int res = acceso.Escribir("PEDIDO_GOLOSINA_INSERTAR", parametros);
            //INSERT INTO PEDIDO_GOLOSINA VALUES (@idpedido, @idgolosina)
            return res;
        }
    }
}
