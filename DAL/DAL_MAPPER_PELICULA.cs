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
    public class DAL_MAPPER_PELICULA : DAL_MAPPER<BE_PELICULA>
    {
        public DAL_MAPPER_PELICULA()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_PELICULA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@titulo", entidad.Titulo);
            parametros.Add(p);
            p = acceso.CrearParametro("@director", entidad.Director);
            parametros.Add(p);
            p = acceso.CrearParametro("@duracion", entidad.Duracion);
            parametros.Add(p);
            p = acceso.CrearParametro("@genero", entidad.Genero.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@descripcion", entidad.Descripcion);
            parametros.Add(p);
            p = acceso.CrearParametro("@imagen", entidad.Imagen);
            parametros.Add(p);

            int res = acceso.Escribir("PELICULA_INSERTAR", parametros);
            //INSERT INTO PELICULA VALUES (@titulo, @director, @duracion, @genero, @descripcion, @imagen)
            return res;
        }

        public override int Baja(BE_PELICULA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("PELICULA_BORRAR", parametros);
            //DELETE FROM PELICULA WHERE id = @id
            return res;
        }

        public override int Modificacion(BE_PELICULA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@titulo", entidad.Titulo);
            parametros.Add(p);
            p = acceso.CrearParametro("@director", entidad.Director);
            parametros.Add(p);
            p = acceso.CrearParametro("@duracion", entidad.Duracion);
            parametros.Add(p);
            p = acceso.CrearParametro("@genero", entidad.Genero.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@descripcion", entidad.Descripcion);
            parametros.Add(p);
            p = acceso.CrearParametro("@imagen", entidad.Imagen);
            parametros.Add(p);

            int res = acceso.Escribir("PELICULA_EDITAR", parametros);
            /*
            UPDATE PELICULA SET 
                titulo = @titulo, 
                director = @director,
                duracion = @duracion,
                genero = @genero,
                descripcion = @descripcion,
                imagen = @imagen
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_PELICULA> Buscar(BE_PELICULA entidad)
        {
            List<BE_PELICULA> peliculas = new List<BE_PELICULA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@titulo", entidad.Titulo);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PELICULA_BUSCAR", parametros);
            //SELECT * FROM PELICULA WHERE titulo = @titulo
            foreach (DataRow dr in tabla.Rows)
            {
                peliculas.Add(Convertir(dr));
            }
            return peliculas;
        }

        public BE_PELICULA BuscarConId(int idpelicula)
        {
            List<BE_PELICULA> peliculas = new List<BE_PELICULA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", idpelicula);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PELICULA_BUSCARID", parametros);
            //SELECT * FROM PELICULA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                peliculas.Add(Convertir(dr));
            }
            return peliculas[0];
        }

        public override List<BE_PELICULA> TraerTodos()
        {
            List<BE_PELICULA> peliculas = new List<BE_PELICULA>();
            DataTable tabla = acceso.Leer("PELICULA_LISTAR", null);
            //SELECT * FROM PELICULA
            foreach (DataRow dr in tabla.Rows)
            {
                peliculas.Add(Convertir(dr));
            }
            return peliculas;
        }

        internal override BE_PELICULA Convertir(DataRow registro)
        {
            BE_PELICULA pelicula = new BE_PELICULA();
            pelicula.Id = int.Parse(registro["id"].ToString());
            pelicula.Titulo = registro["titulo"].ToString();
            pelicula.Director = registro["director"].ToString();
            pelicula.Duracion = int.Parse(registro["duracion"].ToString());
            pelicula.Genero = (BE_PELICULA_GENERO_ENUM)Enum.Parse(typeof(BE_PELICULA_GENERO_ENUM), registro["genero"].ToString());
            pelicula.Descripcion = registro["descripcion"].ToString();
            pelicula.Imagen = (byte[])registro["imagen"];
            return pelicula;
        }
    }
}
