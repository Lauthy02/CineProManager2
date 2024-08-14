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
    public class DAL_MAPPER_SALA : DAL_MAPPER<BE_SALA>
    {
        DAL_MAPPER_FUNCION dalfuncion = new DAL_MAPPER_FUNCION();

        public DAL_MAPPER_SALA()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_SALA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@numerodesala", entidad.NumeroDeSala);
            parametros.Add(p);
            p = acceso.CrearParametro("@capacidad", entidad.Capacidad);
            parametros.Add(p);
            p = acceso.CrearParametro("@formato", entidad.Formato.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@precio", entidad.Precio);
            parametros.Add(p);

            int res = acceso.Escribir("SALA_INSERTAR", parametros);
            //INSERT INTO SALA VALUES (@id, @numerodesala, @capacidad, @formato, @precio)
            return res;
        }

        public override int Baja(BE_SALA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("SALA_BORRAR", parametros);
            //DELETE FROM SALA WHERE id = @id
            return res;
        }

        public override List<BE_SALA> Buscar(BE_SALA entidad)
        {
            List<BE_SALA> salas = new List<BE_SALA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("SALA_BUSCAR", parametros);
            //SELECT * FROM SALA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                salas.Add(Convertir(dr));
            }

            foreach (var sala in salas)
            {
                LlenarFunciones(sala);
            }
            return salas;
        }

        public BE_SALA BuscarConId(int idsala)
        {
            List<BE_SALA> salas = new List<BE_SALA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", idsala);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("SALA_BUSCARID", parametros);
            //SELECT * FROM SALA WHERE id = @id
            foreach (DataRow dr in tabla.Rows)
            {
                salas.Add(Convertir(dr));
            }

            foreach (var sala in salas)
            {
                LlenarFunciones(sala);
            }
            return salas[0];
        }

        public override int Modificacion(BE_SALA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@numerodesala", entidad.NumeroDeSala);
            parametros.Add(p);
            p = acceso.CrearParametro("@capacidad", entidad.Capacidad);
            parametros.Add(p);
            p = acceso.CrearParametro("@formato", entidad.Formato.ToString());
            parametros.Add(p);
            p = acceso.CrearParametro("@precio", entidad.Precio);
            parametros.Add(p);

            int res = acceso.Escribir("SALA_EDITAR", parametros);
            /*
            UPDATE SALA SET 
                numerodesala = @numerodesala,
                capacidad = @capacidad, 
                formato = @formato,
                precio = @precio
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_SALA> TraerTodos()
        {
            List<BE_SALA> salas = new List<BE_SALA>();
            DataTable tabla = acceso.Leer("SALA_LISTAR", null);
            //SELECT * FROM SALA
            foreach (DataRow dr in tabla.Rows)
            {
                salas.Add(Convertir(dr));
            }

            foreach (var sala in salas)
            {
                LlenarFunciones(sala);
            }
            return salas;
        }

        internal override BE_SALA Convertir(DataRow registro)
        {
            BE_SALA sala = new BE_SALA();
            sala.Id = int.Parse(registro["id"].ToString());
            sala.NumeroDeSala = int.Parse(registro["numerodesala"].ToString());
            sala.Capacidad = int.Parse(registro["capacidad"].ToString());
            sala.Formato = (BE_SALA_FORMATO_ENUM)Enum.Parse(typeof(BE_SALA_FORMATO_ENUM), registro["formato"].ToString());
            sala.Precio = float.Parse(registro["precio"].ToString());
            return sala;
        }

        public void LlenarFunciones(BE_SALA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idsala", entidad.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("SALA_FUNCION_BUSCAR", parametros);
            //SELECT * FROM SALA_FUNCION WHERE idsala = @idsala
            foreach (DataRow dr in tabla.Rows)
            {
                entidad.ListaDeFunciones.Add(dalfuncion.BuscarConId(int.Parse(dr["idfuncion"].ToString())));
            }
        }
    }
}
