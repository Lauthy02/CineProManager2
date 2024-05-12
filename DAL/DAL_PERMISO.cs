using BE;
using BE.PERMISOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PERMISO
    {
        internal DAL_ACCESOBD acceso;

        public DAL_PERMISO()
        {
            acceso = new DAL_ACCESOBD();
            acceso.AbrirConexion();
        }

        public Array TraerTodosLosPermisos()
        {
            return Enum.GetValues(typeof(BE_PERMISO_TIPO_ENUM));
        }

        public int AltaPermiso(BE_PERMISO permiso, bool esrol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", permiso.Nombre);
            parametros.Add(p);
            if (esrol)
            {
                p = acceso.CrearParametro("@permiso", DBNull.Value);
                parametros.Add(p);
            }
            else
            {
                p = acceso.CrearParametro("@permiso", permiso.Nombre.ToString());
                parametros.Add(p);
            }

            int res = acceso.Escribir("PERMISO_INSERTAR", parametros);
            //PERMISO_INSERTAR tiene que tener: INSERT INTO PERMISOS VALUES (@nombre, @permiso)
            return res;
        }

        public void AltaRol(BE_ROL rol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", rol.Id);
            parametros.Add(p);

            int res = acceso.Escribir("PERMISO_PERMISO_BORRAR", parametros);
            //PERMISO_PERMISO_BORRAR tiene que tener: DELETE FROM PERMISOS_PERMISOS WHERE idpermisopadre = @id

            List<SqlParameter> parametros2 = new List<SqlParameter>();
            foreach (var hijo in rol.ListaDeHijos)
            {
                SqlParameter p2 = acceso.CrearParametro("@idpermisopadre", rol.Id);
                parametros2.Add(p2);
                p2 = acceso.CrearParametro("@idpermisohijo", hijo.Id);
                parametros2.Add(p2);

                res = acceso.Escribir("PERMISO_PERMISO_INSERTAR", parametros2);
                //PERMISO_PERMISO_INSERTAR tiene que tener: INSERT INTO PERMISOS_PERMISOS VALUES (@idpermisopadre, @idpermisohijo) 
            }
        }

        //Permiso = Acciones
        public IList<BE_PERMISO> TraerTodo(string rol)
        {
            //var where = "IS NULL";
            var where = "NULL";
            if (!string.IsNullOrEmpty(rol))
            {
                where = rol;
            }

            IList<BE_PERMISO> listadepermisos = new List<BE_PERMISO>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@where", where);
            parametros.Add(p);
            DataTable tabla = acceso.Leer("PERMISO_LISTAR_RECURSIVO", parametros);
            /*
            PERMISO_LISTAR_RECURSIVO tiene que tener: 
            WITH recursivo AS	(
						SELECT PP2.idpermisopadre, PP2.idpermisohijo FROM PERMISOS_PERMISOS PP2
						WHERE PP2.idpermisopadre = @where --acá se va variando la familia que busco
						UNION ALL 
						SELECT PP1.idpermisopadre, PP1.idpermisohijo FROM PERMISOS_PERMISOS PP1 
						inner join recursivo rec ON rec.idpermisohijo = PP1.idpermisopadre
					)
					SELECT rec.idpermisopadre, rec.idpermisohijo, P.id, P.nombre, P.permiso
					FROM recursivo rec 
					inner join PERMISOS P ON rec.idpermisohijo = P.id
            */

            foreach (DataRow dr in tabla.Rows)
            {
                int idpadre = 0;
                if (dr["idpermisopadre"] != DBNull.Value)
                {
                    idpadre = Convert.ToInt32(dr["idpermisopadre"]);
                }

                var id = int.Parse(dr["id"].ToString());
                var nombre = dr["nombre"].ToString();

                var permiso = string.Empty;
                if (dr["permiso"] != DBNull.Value)
                {
                    permiso = dr["permiso"].ToString();
                }

                BE_PERMISO permisoaux;

                if (string.IsNullOrEmpty(permiso))
                {
                    permisoaux = new BE_ROL();
                }
                else
                {
                    permisoaux = new BE_ACCION();
                }

                permisoaux.Id = id;
                permisoaux.Nombre = nombre;
                if (!string.IsNullOrEmpty(permiso))
                {
                    permisoaux.PermisoTipoEnum = (BE_PERMISO_TIPO_ENUM)Enum.Parse(typeof(BE_PERMISO_TIPO_ENUM), permiso);
                }

                var padre = TraerUnPermiso(idpadre, listadepermisos);

                if (padre == null)
                {
                    listadepermisos.Add(permisoaux);
                }
                else
                {
                    padre.AgregarHijo(permisoaux);
                }
            }
            return listadepermisos;
        }

        //Accion = Patente
        public IList<BE_ACCION> TraerTodasLasAcciones()
        {
            IList<BE_ACCION> listadeacciones = new List<BE_ACCION>();
            DataTable tabla = acceso.Leer("ACCION_LISTAR", null);
            /*
            ACCION_LISTAR tiene que tener: SELECT * FROM PERMISOS WHERE permiso IS NOT NULL
            Me traigo los que no son NULL porque en la base los registros que en el campo permiso tengan el valor de NULL van a ser roles
            1	IgresarAVentas  Accion  --> Es una accion/patente
            2	VerVenta        Accion  --> Es una accion/patente
            3   Administrador   NULL    --> Es un rol/familia
            */

            foreach (DataRow dr in tabla.Rows)
            {
                var id = int.Parse(dr["id"].ToString());
                var nombre = dr["nombre"].ToString();
                var permiso = dr["permiso"].ToString();

                BE_ACCION accionaux = new BE_ACCION();
                accionaux.Id = id;
                accionaux.Nombre = nombre;
                accionaux.PermisoTipoEnum = (BE_PERMISO_TIPO_ENUM)Enum.Parse(typeof(BE_PERMISO_TIPO_ENUM), permiso);

                listadeacciones.Add(accionaux);
            }
            return listadeacciones;
        }

        //Rol = Familia
        public IList<BE_ROL> TraerTodosLosRoles()
        {
            IList<BE_ROL> listaderoles = new List<BE_ROL>();
            DataTable tabla = acceso.Leer("ROL_LISTAR", null);
            //ROL_LISTAR tiene que tener: SELECT * FROM PERMISOS WHERE permiso IS NULL

            foreach (DataRow dr in tabla.Rows)
            {
                var id = int.Parse(dr["id"].ToString());
                var nombre = dr["nombre"].ToString();

                BE_ROL rolaux = new BE_ROL();
                rolaux.Id = id;
                rolaux.Nombre = nombre;

                listaderoles.Add(rolaux);
            }
            return listaderoles;
        }

        private BE_PERMISO TraerUnPermiso(int id, IList<BE_PERMISO> listadepermisos)
        {
            BE_PERMISO permisoaux = listadepermisos != null ? listadepermisos.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (permisoaux == null && listadepermisos != null)
            {
                foreach (var permiso in listadepermisos)
                {
                    var hijo = TraerUnPermiso(id, permiso.ListaDeHijos);
                    if (hijo != null && hijo.Id == id)
                    {
                        return hijo;
                    }
                    else
                    {
                        if (hijo != null)
                        {
                            return TraerUnPermiso(id, hijo.ListaDeHijos);
                        }
                    }
                }
            }
            return permisoaux;
        }

        public void LlenarUsuarioPermisos(BE_USUARIO usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", usuario.Id);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("USUARIO_PERMISO_LISTAR", parametros);
            //USUARIO_PERMISO_LISTAR tiene que tener: SELECT P.* FROM USUARIOS_PERMISOS UP INNER JOIN PERMISOS P ON UP.idpermiso = P.id WHERE idusuario = @id

            usuario.ListaDePermisos.Clear();

            foreach (DataRow dr in tabla.Rows)
            {
                int idpermiso = int.Parse(dr["id"].ToString());
                string nombrepermiso = dr["nombre"].ToString();

                var permisop = string.Empty;
                if (dr["permiso"] != DBNull.Value)
                {
                    permisop = dr["nombre"].ToString();
                }

                BE_PERMISO permisoaux;
                if (!String.IsNullOrEmpty(permisop))
                {
                    permisoaux = new BE_ACCION();
                    permisoaux.Id = idpermiso;
                    permisoaux.Nombre = nombrepermiso;
                    permisoaux.PermisoTipoEnum = (BE_PERMISO_TIPO_ENUM)Enum.Parse(typeof(BE_PERMISO_TIPO_ENUM), permisop);
                    usuario.ListaDePermisos.Add(permisoaux);
                }
                else
                {
                    permisoaux = new BE_ROL();
                    permisoaux.Id = idpermiso;
                    permisoaux.Nombre = nombrepermiso;

                    //var f = TraerTodo("=" + idpermiso);
                    var f = TraerTodo(idpermiso.ToString());
                    foreach (var item in f)
                    {
                        permisoaux.AgregarHijo(item);
                    }
                    usuario.ListaDePermisos.Add(permisoaux);
                }
            }
        }

        public void LlenarRolPermisos(BE_ROL rol)
        {
            rol.VaciarHijos();
            foreach (var item in TraerTodo(rol.Id.ToString()))
            {
                rol.AgregarHijo(item);
            }
        }
    }
}
