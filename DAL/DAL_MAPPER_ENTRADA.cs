using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MAPPER_ENTRADA : DAL_MAPPER<BE_ENTRADA>
    {
        DAL_MAPPER_USUARIO dalusuario = new DAL_MAPPER_USUARIO();
        DAL_MAPPER_FUNCION dalfuncion = new DAL_MAPPER_FUNCION();

        public DAL_MAPPER_ENTRADA()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idusuario", entidad.Cliente.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idfuncion",entidad.Funcion.Id);
            parametros.Add(p);
            //p = acceso.CrearParametro("@butaca", entidad.AsientoReservado);
            //parametros.Add(p);
            p = acceso.CrearParametro("@fehcadereserva", entidad.FechaDeReserva);
            parametros.Add(p);
            p = acceso.CrearParametro("@estado", entidad.Estado.ToString());
            parametros.Add(p);

            int res = acceso.Escribir("ENTRADA_INSERTAR", parametros);
            //INSERT INTO ENTRADA VALUES (@idusuario, @idfuncion, @fehcadereserva, @estado)
            return res;
        }

        public override int Baja(BE_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("ENTRADA_BORRAR", parametros);
            //DELETE FROM ENTRADA WHERE id = @id
            return res;
        }

        public override List<BE_ENTRADA> Buscar(BE_ENTRADA entidad)
        {
            List<BE_ENTRADA> entradas = new List<BE_ENTRADA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("ENTRADA_BUSCAR", parametros);
            //SELECT * FROM ENTRADA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entradas.Add(Convertir(dr));
            }

            foreach (var entrada in entradas)
            {
                LlenarUsuario(entrada);
                LlenarFuncion(entrada);
            }
            return entradas;
        }

        public List<BE_ENTRADA> BuscarEstado(string estado)
        {
            List<BE_ENTRADA> entradas = new List<BE_ENTRADA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@estado", estado);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("ENTRADA_BUSCARESTADO", parametros);
            //SELECT * FROM ENTRADA WHERE estado = @estado
            foreach (DataRow dr in tabla.Rows)
            {
                entradas.Add(Convertir(dr));
            }

            foreach (var entrada in entradas)
            {
                LlenarUsuario(entrada);
                LlenarFuncion(entrada);
            }
            return entradas;
        }

        public override int Modificacion(BE_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idusuario", entidad.Cliente.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idfuncion", entidad.Funcion.Id);
            parametros.Add(p);
            //p = acceso.CrearParametro("@butaca", entidad.Duracion);
            //parametros.Add(p);
            p = acceso.CrearParametro("@fehcadereserva", entidad.FechaDeReserva);
            parametros.Add(p);
            p = acceso.CrearParametro("@estado", entidad.Estado.ToString());
            parametros.Add(p);

            int res = acceso.Escribir("ENTRADA_EDITAR", parametros);
            /*
            UPDATE PELICULA SET 
                idusuario = @idusuario, 
                idfuncion = @idfuncion,
                fehcadereserva = @fehcadereserva,
                estad = @estado
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_ENTRADA> TraerTodos()
        {
            List<BE_ENTRADA> entradas = new List<BE_ENTRADA>();
            DataTable tabla = acceso.Leer("ENTRADA_LISTAR", null);
            //SELECT * FROM ENTRADA
            foreach (DataRow dr in tabla.Rows)
            {
                entradas.Add(Convertir(dr));
            }

            foreach (var entrada in entradas)
            {
                LlenarUsuario(entrada);
                LlenarFuncion(entrada);
            }
            return entradas;
        }

        internal override BE_ENTRADA Convertir(DataRow registro)
        {
            BE_ENTRADA entrada = new BE_ENTRADA();
            entrada.Id = int.Parse(registro["id"].ToString());
            entrada.Cliente.Id = int.Parse(registro["idusuario"].ToString());
            entrada.Funcion.Id = int.Parse(registro["idfuncion"].ToString());
            //entrada.AsientoReservado = registro["butaca"].ToString();
            entrada.FechaDeReserva = DateTime.Parse(registro["fechadereserva"].ToString());
            entrada.Estado = (BE_ENTRADA_ESTADO_ENUM)Enum.Parse(typeof(BE_ENTRADA_ESTADO_ENUM), registro["estado"].ToString());
            return entrada;
        }

        private void LlenarUsuario(BE_ENTRADA entidad)
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

        private void LlenarFuncion(BE_ENTRADA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Cliente.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("FUNCION_BUSCARID", parametros);
            //SELECT * FROM USUARIO WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Funcion = dalfuncion.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }
    }
}
