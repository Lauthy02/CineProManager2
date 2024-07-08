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
    public class DAL_MAPPER_CINE : DAL_MAPPER<BE_CINE>
    {
        DAL_MAPPER_PELICULA dalpelicula = new DAL_MAPPER_PELICULA();
        DAL_MAPPER_SALA dalsala = new DAL_MAPPER_SALA();

        public DAL_MAPPER_CINE()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@zona", entidad.Zona);
            parametros.Add(p);
            p = acceso.CrearParametro("@direccion", entidad.Direccion);
            parametros.Add(p);

            int res = acceso.Escribir("CINE_INSERTAR", parametros);
            //INSERT INTO CINE VALUES (@nombre, @zona, @direccion)
            return res;
        }

        public override int Baja(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("CINE_BORRAR", parametros);
            //DELETE FROM CINE WHERE id = @id
            return res;
        }

        public override int Modificacion(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@zona", entidad.Zona);
            parametros.Add(p);
            p = acceso.CrearParametro("@direccion", entidad.Direccion);
            parametros.Add(p);

            int res = acceso.Escribir("CINE_EDITAR", parametros);
            /*
            UPDATE CINE SET 
                nombre = @nombre, 
                zona = @zona,
                direccion = @direccion
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_CINE> Buscar(BE_CINE entidad)
        {
            List<BE_CINE> cines = new List<BE_CINE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("CINE_BUSCAR", parametros);
            //SELECT * FROM CINE WHERE nombre = @nombre
            foreach (DataRow dr in tabla.Rows)
            {
                cines.Add(Convertir(dr));
            }

            foreach (var cine in cines)
            {
                LlenarCartelera(cine);
            }

            foreach (var cine in cines)
            {
                LlenarSalas(cine);
            }
            return cines;
        }

        public override List<BE_CINE> TraerTodos()
        {
            List<BE_CINE> cines = new List<BE_CINE>();
            DataTable tabla = acceso.Leer("CINE_LISTAR", null);
            //SELECT * FROM CINE
            foreach (DataRow dr in tabla.Rows)
            {
                cines.Add(Convertir(dr));
            }

            foreach (var cine in cines)
            {
                LlenarCartelera(cine);
            }

            foreach (var cine in cines)
            {
                LlenarSalas(cine);
            }
            return cines;
        }

        internal override BE_CINE Convertir(DataRow registro)
        {
            BE_CINE cine = new BE_CINE();
            cine.Id = int.Parse(registro["id"].ToString());
            cine.Nombre = registro["nombre"].ToString();
            cine.Zona = registro["zona"].ToString();
            cine.Direccion = registro["direccion"].ToString();
            return cine;
        }

        public void LlenarCartelera(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idcine", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("CARTELERA_BUSCAR", parametros);
            //SELECT * FROM CARTELERA WHERE idcine = @idcine
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.Cartelera.ListaDePeliculas.Add(dalpelicula.BuscarConId(int.Parse(dr["idpelicula"].ToString())));
            }
        }

        public void LlenarSalas(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idcine", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("CINE_SALA_BUSCAR", parametros);
            //SELECT * FROM CINE_SALA WHERE idcine = @idcine
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.ListaDeSalas.Add(dalsala.BuscarConId(int.Parse(dr["idsala"].ToString())));
            }
        }
    }
}
