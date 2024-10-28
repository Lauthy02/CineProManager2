using BE;
using DAL.DIGITOVERIFICADOR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MAPPER_PEDIDO : DAL_MAPPER<BE_PEDIDO>
    {
        DAL_MAPPER_USUARIO dalusuario = new DAL_MAPPER_USUARIO();
        DAL_MAPPER_GOLOSINA dalgolosina = new DAL_MAPPER_GOLOSINA();

        public DAL_MAPPER_PEDIDO()
        {
            acceso.AbrirConexion();        
        }

        public override int Alta(BE_PEDIDO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idcliente", entidad.Cliente.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@fecha", entidad.Fecha);
            parametros.Add(p);
            p = acceso.CrearParametro("@estado", entidad.Estado.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@montototal", entidad.MontoTotal);
            parametros.Add(p);

            int res = acceso.Escribir("PEDIDO_INSERTAR", parametros);
            //INSERT INTO PEDIDO VALUES (@id, @idcliente, @fecha, @estado, @montototal)
            return res;
        }

        public override int Baja(BE_PEDIDO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("PEDIDO_BORRAR", parametros);
            //DELETE FROM PEDIDO WHERE id = @id
            return res;
        }

        public override List<BE_PEDIDO> Buscar(BE_PEDIDO entidad)
        {
            List<BE_PEDIDO> pedidos = new List<BE_PEDIDO>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PEDIDO_BUSCAR", parametros);
            //SELECT * FROM PEDIDO WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                pedidos.Add(Convertir(dr));
            }

            foreach (var pedido in pedidos)
            {
                LlenarCliente(pedido);
                LlenarGolosinas(pedido);
            }

            return pedidos;
        }

        public List<BE_PEDIDO> BuscarEstado(string estado)
        {
            List<BE_PEDIDO> pedidos = new List<BE_PEDIDO>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@estado", estado);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PEDIDO_BUSCARESTADO", parametros);
            //SELECT * FROM PEDIDO WHERE estado = @estado
            foreach (DataRow dr in tabla.Rows)
            {
                pedidos.Add(Convertir(dr));
            }

            foreach (var pedido in pedidos)
            {
                LlenarCliente(pedido);
                LlenarGolosinas(pedido);
            }
            return pedidos;
        }

        public override int Modificacion(BE_PEDIDO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idcliente", entidad.Cliente.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@fecha", entidad.Fecha);
            parametros.Add(p);
            p = acceso.CrearParametro("@estado", entidad.Estado.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@montototal", entidad.MontoTotal);
            parametros.Add(p);

            int res = acceso.Escribir("PEDIDO_EDITAR", parametros);
            /*
            UPDATE PEDIDO SET 
                idcliente = @idcliente, 
                fecha = @fecha,
                estado = @estado,
                montototal = @montototal,
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_PEDIDO> TraerTodos()
        {
            List<BE_PEDIDO> pedidos = new List<BE_PEDIDO>();
            DataTable tabla = acceso.Leer("PEDIDO_LISTAR", null);
            //SELECT * FROM PEDIDO
            foreach (DataRow dr in tabla.Rows)
            {
                pedidos.Add(Convertir(dr));
            }

            foreach (var pedido in pedidos)
            {
                LlenarCliente(pedido);
                LlenarGolosinas(pedido);
            }

            return pedidos;
        }

        internal override BE_PEDIDO Convertir(DataRow registro)
        {
            BE_PEDIDO pedido = new BE_PEDIDO();
            pedido.Id = int.Parse(registro["id"].ToString());
            pedido.Cliente.Id = int.Parse(registro["idcliente"].ToString());
            pedido.Fecha = DateTime.Parse(registro["fecha"].ToString());
            pedido.Estado = (BE_PEDIDO_ESTADO_ENUM)Enum.Parse(typeof(BE_PEDIDO_ESTADO_ENUM), registro["estado"].ToString());
            pedido.MontoTotal = float.Parse(registro["montototal"].ToString());
            return pedido;
        }

        private void LlenarCliente(BE_PEDIDO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Cliente.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("USUARIO_BUSCARID", parametros);
            //SELECT * FROM USUARIO WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Cliente = dalusuario.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }

        private void LlenarGolosinas(BE_PEDIDO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idpedido", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PEDIDO_GOLOSINA_BUSCAR", parametros);
            //SELECT * FROM PEDIDO_GOLOSINA WHERE idpedido = @idpedido
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Golosinas.Add(dalgolosina.BuscarConId(int.Parse(dr["idgolosina"].ToString())));
            }
        }
    }
}
