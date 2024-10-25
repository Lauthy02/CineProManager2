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
    public class DAL_MAPPER_GOLOSINA : DAL_MAPPER<BE_GOLOSINA>
    {
        public DAL_MAPPER_GOLOSINA()
        {
            acceso.AbrirConexion();        
        }

        public override int Alta(BE_GOLOSINA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@precio", entidad.Precio);
            parametros.Add(p);

            int res = acceso.Escribir("GOLOSINA_INSERTAR", parametros);
            //INSERT INTO GOLOSINA VALUES (@nombre, @precio)
            return res;
        }

        public override int Baja(BE_GOLOSINA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("GOLOSINA_BORRAR", parametros);
            //DELETE FROM GOLOSINA WHERE id = @id
            return res;
        }

        public override List<BE_GOLOSINA> Buscar(BE_GOLOSINA entidad)
        {
            List<BE_GOLOSINA> golosinas = new List<BE_GOLOSINA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("GOLOSINA_BUSCAR", parametros);
            //SELECT * FROM GOLOSINA WHERE nombre = @nombre
            foreach (DataRow dr in tabla.Rows)
            {
                golosinas.Add(Convertir(dr));
            }
            return golosinas;
        }

        public override int Modificacion(BE_GOLOSINA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@precio", entidad.Precio);
            parametros.Add(p);

            int res = acceso.Escribir("GOLOSINA_EDITAR", parametros);
            /*
            UPDATE GOLOSINA SET 
                nombre = @nombre, 
                precio = @precio,
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_GOLOSINA> TraerTodos()
        {
            List<BE_GOLOSINA> golosinas = new List<BE_GOLOSINA>();
            DataTable tabla = acceso.Leer("GOLOSINA_LISTAR", null);
            //SELECT * FROM GOLOSINA
            foreach (DataRow dr in tabla.Rows)
            {
                golosinas.Add(Convertir(dr));
            }

            return golosinas;
        }

        internal override BE_GOLOSINA Convertir(DataRow registro)
        {
            BE_GOLOSINA golosina = new BE_GOLOSINA();
            golosina.Id = int.Parse(registro["id"].ToString());
            golosina.Nombre = registro["nombre"].ToString();
            golosina.Precio = float.Parse(registro["precio"].ToString());
            return golosina;
        }
    }
}
