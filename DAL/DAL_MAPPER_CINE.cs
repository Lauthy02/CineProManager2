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
            //INSERT INTO CINES VALUES (@nombre, @zona, @direccion)
            return res;
        }

        public override int Baja(BE_CINE entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("CINE_BORRAR", parametros);
            //DELETE FROM CINES WHERE id = @id
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
            UPDATE CINES SET 
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
            //SELECT * FROM CINES WHERE nombre = @nombre
            foreach (DataRow dr in tabla.Rows)
            {
                cines.Add(Convertir(dr));
            }
            return cines;
        }

        public override List<BE_CINE> TraerTodos()
        {
            List<BE_CINE> cines = new List<BE_CINE>();
            DataTable tabla = acceso.Leer("CINE_LISTAR", null);
            //SELECT * FROM CINES
            foreach (DataRow dr in tabla.Rows)
            {
                cines.Add(Convertir(dr));
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
    }
}
