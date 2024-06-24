using BE;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MULTIIDIOMA
{
    public class DAL_MAPPER_IDIOMA : DAL_MAPPER<BE_IDIOMA>
    {
        public DAL_MAPPER_IDIOMA()
        {
            acceso.AbrirConexion();
        }

        public override int Alta(BE_IDIOMA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            if (entidad.PorDefecto)
            {
                p = acceso.CrearParametro("@pordefecto", 1);
                parametros.Add(p);
            }
            else
            {
                p = acceso.CrearParametro("@pordefecto", 0);
                parametros.Add(p);
            }

            int res = acceso.Escribir("IDIOMA_INSERTAR", parametros);
            //INSERT INTO IDIOMA VALUES (@nombre, @pordefecto)
            return res;
        }

        public override int Baja(BE_IDIOMA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("IDIOMA_BORRAR", parametros);
            //DELETE FROM IDIOMA WHERE id = @id
            return res;
        }

        public override List<BE_IDIOMA> Buscar(BE_IDIOMA entidad)
        {
            List<BE_IDIOMA> idiomas = new List<BE_IDIOMA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("IDIOMA_BUSCAR", parametros);
            //SELECT * FROM IDIOMA WHERE nombre = @nombre
            foreach (DataRow dr in tabla.Rows)
            {
                idiomas.Add(Convertir(dr));
            }
            return idiomas;
        }

        public override int Modificacion(BE_IDIOMA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);

            int res = acceso.Escribir("IDIOMA_EDITAR", parametros);
            /*
            update IDIOMA SET 
                nombre = @nombre
            WHERE id = @id
            */
            return res;
        }

        public override List<BE_IDIOMA> TraerTodos()
        {
            List<BE_IDIOMA> idiomas = new List<BE_IDIOMA>();
            DataTable tabla = acceso.Leer("IDIOMA_LISTAR", null);
            //SELECT * FROM IDIOMA
            foreach (DataRow dr in tabla.Rows)
            {
                idiomas.Add(Convertir(dr));
            }
            return idiomas;
        }

        internal override BE_IDIOMA Convertir(DataRow registro)
        {
            BE_IDIOMA idioma = new BE_IDIOMA();
            idioma.Id = int.Parse(registro["id"].ToString());
            idioma.Nombre = registro["nombre"].ToString();
            idioma.PorDefecto = bool.Parse(registro["pordefecto"].ToString());
            return idioma;
        }

        public void LlenarUsuarioIdioma(BE_USUARIO usuario)
        {
            List<BE_IDIOMA> idiomasaux = new List<BE_IDIOMA>();
            idiomasaux = TraerTodos();
            usuario.Idioma = idiomasaux[usuario.Idioma.Id];
        }

        public IDictionary<string, BE_TRADUCCION> ObtenerTraducciones(BE_IDIOMA idioma)
        {
            IDictionary<string, BE_TRADUCCION> traducciones = new Dictionary<string, BE_TRADUCCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", idioma.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("OBTENER_TRADUCCIONES", parametros);
            //SELECT t.ididioma,t.texto AS traduccion_traduccion, e.id, e.nombre AS nombre_etiqueta FROM TRADUCCION t INNER JOIN ETIQUETA e ON t.idetiqueta = e.id WHERE t.ididioma = @ididioma

            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow dr in tabla.Rows)
                {
                    var etiqueta = dr["nombre_etiqueta"].ToString();
                    traducciones.Add(etiqueta, new BE_TRADUCCION() 
                    {
                        //Id = int.Parse(dr["id"].ToString()),
                        Idioma = idioma,
                        Etiqueta = new BE_ETIQUETA() 
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Nombre = dr["nombre_etiqueta"].ToString()
                        },
                        Texto = dr["traduccion_traduccion"].ToString()
                    });
                }
            }
            return traducciones;
        }
    }
}
