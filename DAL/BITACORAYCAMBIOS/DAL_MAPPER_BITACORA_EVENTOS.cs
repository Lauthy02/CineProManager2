using BE;
using BE.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BITACORAYCAMBIOS
{
    public class DAL_MAPPER_BITACORA_EVENTOS : DAL_MAPPER<BE_BITACORA_EVENTOS>
    {
        DAL_MAPPER_USUARIO dalusuario = new DAL_MAPPER_USUARIO();

        public DAL_MAPPER_BITACORA_EVENTOS()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_BITACORA_EVENTOS entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idusuario", entidad.Usuario.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@fecha", entidad.Fecha);
            parametros.Add(p);
            p = acceso.CrearParametro("@accion", entidad.Accion);
            parametros.Add(p);

            int res = acceso.Escribir("BITACORAEVENTOS_INSERTAR", parametros);
            //INSERT INTO BITACORAEVENTOS VALUES (@idusuario, @fecha, @accion)
            return res;
        }

        public override int Baja(BE_BITACORA_EVENTOS entidad)
        {
            throw new NotImplementedException();
        }

        public override List<BE_BITACORA_EVENTOS> Buscar(BE_BITACORA_EVENTOS entidad)
        {
            throw new NotImplementedException();
        }

        public override int Modificacion(BE_BITACORA_EVENTOS entidad)
        {
            throw new NotImplementedException();
        }

        public override List<BE_BITACORA_EVENTOS> TraerTodos()
        {
            List<BE_BITACORA_EVENTOS> bitacora = new List<BE_BITACORA_EVENTOS>();
            DataTable tabla = acceso.Leer("BITACORAEVENTOS_LISTAR", null);
            //SELECT * FROM BITACORAEVENTOS
            foreach (DataRow dr in tabla.Rows)
            {
                bitacora.Add(Convertir(dr));
            }

            foreach (var registro in bitacora)
            {
                LlenarUsuario(registro);
            }
            return bitacora;
        }

        internal override BE_BITACORA_EVENTOS Convertir(DataRow registro)
        {
            BE_BITACORA_EVENTOS bitacora = new BE_BITACORA_EVENTOS();
            bitacora.Id = int.Parse(registro["id"].ToString());
            bitacora.Usuario.Id = int.Parse(registro["idusuario"].ToString());
            bitacora.Fecha = DateTime.Parse(registro["fecha"].ToString());
            bitacora.Accion = registro["accion"].ToString();
            return bitacora;
        }

        private void LlenarUsuario(BE_BITACORA_EVENTOS entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Usuario.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("USUARIO_BUSCARID", parametros);
            //SELECT * FROM USUARIO WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Usuario = dalusuario.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }
    }
}
