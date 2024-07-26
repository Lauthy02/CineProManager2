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
            p = acceso.CrearParametro("@pordefecto", 0);
            parametros.Add(p);
            p = acceso.CrearParametro("@listoparausar", 0);
            parametros.Add(p);

            int res = acceso.Escribir("IDIOMA_INSERTAR", parametros);
            //INSERT INTO IDIOMA VALUES (@nombre, @pordefecto, @listoparausar)
            /*Crear un trigger para crear las traducciones de las etiquetas al insertar un idioma
                CREATE TRIGGER trg_DespuesDeInsertarIdioma
                ON IDIOMA
                AFTER INSERT
                AS
                BEGIN
                    -- Insertar traducciones para cada etiqueta existente
                    INSERT INTO TRADUCCION (ididioma, idetiqueta, texto)
                    SELECT i.id, e.id, 'Traducción pendiente'
                    FROM ETIQUETA e
                    CROSS JOIN INSERTED i;
                END;
             */
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
            if (entidad.ListoParaUsar)
            {
                p = acceso.CrearParametro("@listoparausar", 1);
                parametros.Add(p);
            }
            else
            {
                p = acceso.CrearParametro("@listoparausar", 0);
                parametros.Add(p);
            }

            int res = acceso.Escribir("IDIOMA_EDITAR", parametros);
            /*
            update IDIOMA SET 
                nombre = @nombre
                listoparausar = @listoparausar
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
            idioma.ListoParaUsar = bool.Parse(registro["listoparausar"].ToString());
            return idioma;
        }

        public void LlenarUsuarioIdioma(BE_USUARIO usuario)
        {
            List<BE_IDIOMA> idiomasaux = new List<BE_IDIOMA>();
            idiomasaux = TraerTodos();
            BE_IDIOMA idiomaaux = new BE_IDIOMA();
            idiomaaux = idiomasaux.FirstOrDefault(idioma => idioma.Id == usuario.Idioma.Id);
            
            usuario.Idioma.Id = idiomaaux.Id;
            usuario.Idioma.Nombre = idiomaaux.Nombre;
            usuario.Idioma.PorDefecto = idiomaaux.PorDefecto;
        }

        public List<BE_TRADUCCION> ObtenerTraducciones(BE_IDIOMA idioma)
        {
            List<BE_TRADUCCION> traducciones = new List<BE_TRADUCCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@ididioma", idioma.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("OBTENER_TRADUCCIONES", parametros);
            //SELECT t.id AS 'idtraduccion', i.id AS 'ididioma', i.nombre AS 'nombreidioma', i.pordefecto, e.id AS 'idetiqueta', e.nombre AS 'nombreetiqueta', t.texto AS 'traduccion' FROM TRADUCCION t INNER JOIN IDIOMA i ON t.ididioma = i.id INNER JOIN ETIQUETA e ON t.idetiqueta = e.id WHERE i.id = @ididioma;

            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow dr in tabla.Rows)
                {
                    traducciones.Add(new BE_TRADUCCION()
                    {
                        Id = int.Parse(dr["idtraduccion"].ToString()),
                        Etiqueta = new BE_ETIQUETA()
                        {
                            Id = int.Parse(dr["idetiqueta"].ToString()),
                            Nombre = dr["nombreetiqueta"].ToString()
                        },
                        Idioma = new BE_IDIOMA()
                        {
                            Id = int.Parse(dr["ididioma"].ToString()),
                            Nombre = dr["nombreidioma"].ToString(),
                            PorDefecto = bool.Parse(dr["pordefecto"].ToString()),
                            ListoParaUsar = bool.Parse(dr["pordefecto"].ToString())
                        },
                        Texto = dr["traduccion"].ToString()
                    });
                }
            }
            return traducciones;
        }
    }
}
