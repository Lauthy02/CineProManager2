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
    public class DAL_MAPPER_FUNCION : DAL_MAPPER<BE_FUNCION>
    {
        DAL_MAPPER_PELICULA dalpelicula = new DAL_MAPPER_PELICULA();

        public DAL_MAPPER_FUNCION()
        {
            acceso.AbrirConexion();
        }
        public override int Alta(BE_FUNCION entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idpelicula", entidad.Pelicula.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@horario", entidad.Horario);
            parametros.Add(p);

            int res = acceso.Escribir("FUNCION_INSERTAR", parametros);
            //INSERT INTO FUNCION VALUES (@id, @idpelicula, @horario)
            return res;
        }

        public override int Baja(BE_FUNCION entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("FUNCION_BORRAR", parametros);
            //DELETE FROM FUNCION WHERE id = @id
            return res;
        }

        public override List<BE_FUNCION> Buscar(BE_FUNCION entidad)
        {
            List<BE_FUNCION> funciones = new List<BE_FUNCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idpelicula", entidad.Pelicula.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("FUNCION_BUSCAR", parametros);
            //SELECT * FROM FUNCION WHERE idpelicula = @idpelicula
            foreach (DataRow dr in tabla.Rows)
            {
                funciones.Add(Convertir(dr));
            }

            foreach (var funcion in funciones)
            {
                LlenarPelicula(funcion);
                LlenarButacas(funcion);
            }
            return funciones;
        }

        public BE_FUNCION BuscarConId(int idfuncion)
        {
            List<BE_FUNCION> funciones = new List<BE_FUNCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", idfuncion);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("FUNCION_BUSCARID", parametros);
            //SELECT * FROM FUNCION WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                funciones.Add(Convertir(dr));
            }

            foreach (var funcion in funciones)
            {
                LlenarPelicula(funcion);
                LlenarButacas(funcion);
            }
            return funciones[0];
        }

        public override int Modificacion(BE_FUNCION entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@idpelicula", entidad.Pelicula.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@horario", entidad.Horario);
            parametros.Add(p);

            int res = acceso.Escribir("FUNCION_EDITAR", parametros);
            /*
            UPDATE FUNCION SET 
                idpelicula = @idpelicula, 
                horario = @horario,
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_FUNCION> TraerTodos()
        {
            List<BE_FUNCION> funciones = new List<BE_FUNCION>();
            DataTable tabla = acceso.Leer("FUNCION_LISTAR", null);
            //SELECT * FROM FUNCION
            foreach (DataRow dr in tabla.Rows)
            {
                funciones.Add(Convertir(dr));
            }

            foreach (var funcion in funciones)
            {
                LlenarPelicula(funcion);
                LlenarButacas(funcion);
            }
            return funciones;
        }

        internal override BE_FUNCION Convertir(DataRow registro)
        {
            BE_FUNCION funcion = new BE_FUNCION();
            funcion.Id = int.Parse(registro["id"].ToString());
            funcion.Pelicula.Id = int.Parse(registro["idpelicula"].ToString());
            funcion.Horario = DateTime.Parse(registro["horario"].ToString());
            return funcion;
        }

        public void LlenarPelicula(BE_FUNCION entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Pelicula.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PELICULA_BUSCARID", parametros);
            //SELECT * FROM PELICULA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Pelicula = dalpelicula.BuscarConId(int.Parse(dr["id"].ToString()));
            }
        }

        private void LlenarButacas(BE_FUNCION entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idfuncion", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("BUTACA_OCUPADA_BUSCAR", parametros);
            //SELECT butaca FROM ENTRADA WHERE idfuncion = @idfuncion AND (estado = 'Pagada' OR estado = 'Emitida')
            foreach (DataRow dr in tabla.Rows)
            {
                string butaca = dr["butaca"].ToString();
                string fila = new string(butaca.TakeWhile(c => !char.IsDigit(c)).ToArray());
                string columna = new string(butaca.SkipWhile(c => !char.IsDigit(c)).ToArray());

                BE_BUTACA butacaaux = new BE_BUTACA();
                butacaaux.Fila = (BE_BUTACA_FILA_ENUM)Enum.Parse(typeof(BE_BUTACA_FILA_ENUM), fila);
                butacaaux.Columna = int.Parse(columna);

                entidad.ListaDeAsientosOcupados.Add(butacaaux);
            }
        }
    }
}
