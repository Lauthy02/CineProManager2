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

        public int AltaPermiso(BE_PERMISO permiso, bool esfamilia)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", permiso.Nombre);
            parametros.Add(p);
            if (esfamilia)
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
            //PERMISO_INSERTAR tiene que tener: $@"insert into permiso (nombre,permiso) values (@nombre,@permiso); SELECT ID AS LastID FROM permiso WHERE ID = @@Identity;";
            return res;
        }

        public void AltaRol(BE_ROL rol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", rol.Id);
            parametros.Add(p);

            int res = acceso.Escribir("PERMISO_PERMISO_BORRAR", parametros);
            //PERMISO_PERMISO_BORRAR tiene que tener: $@"delete from permiso_permiso where id_permiso_padre=@id;";

            foreach (var hijo in rol.ListaDeHijos)
            {
                List<SqlParameter> pARAMETROS = new List<SqlParameter>();
                pARAMETROS = new List<SqlParameter>();
                p = acceso.CrearParametro("@id_permiso_padre", rol.Id);
                pARAMETROS.Add(p);
                p = acceso.CrearParametro("@id_permiso_hijo", hijo.Id);
                pARAMETROS.Add(p);

                res = acceso.Escribir("PERMISO_PERMISO_INSERTAR", pARAMETROS);
                //PERMISO_PERMISO_INSERTAR tiene que tener: $@"insert into permiso_permiso (id_permiso_padre,id_permiso_hijo) values (@id_permiso_padre,@id_permiso_hijo)";
            }
        }

        //Permiso = Acciones
        public IList<BE_PERMISO> TraerTodo(string familia)
        {
            var where = "IS NULL";
            if (!string.IsNullOrEmpty(familia))
            {
                where = familia;
            }

            IList<BE_PERMISO> listadepermisos = new List<BE_PERMISO>();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@where", where);
            parametros.Add(p);
            DataTable tabla = acceso.Leer("PERMISO_LISTAR_RECURSIVO", parametros);
            /*
            PERMISO_LISTAR_RECURSIVO tiene que tener: $@"with recursivo as (
            select sp2.id_permiso_padre, sp2.id_permiso_hijo  from permiso_permiso SP2
            where sp2.id_permiso_padre {where} --acá se va variando la familia que busco
            UNION ALL 
            select sp.id_permiso_padre, sp.id_permiso_hijo from permiso_permiso sp 
            inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
            )
            select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.permiso
            from recursivo r 
            inner join permiso p on r.id_permiso_hijo = p.id";
            */

            foreach (DataRow dr in tabla.Rows)
            {
                int idpadre = 0;
                if (dr["id_permiso_padre"] != DBNull.Value)
                {
                    idpadre = Convert.ToInt32(dr["id_permiso_padre"]);
                }

                var id = int.Parse(dr["ID"].ToString());
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
            //ACCION_LISTAR tiene que tener: $@"select * from permiso p where p.permiso is not null;";

            foreach (DataRow dr in tabla.Rows)
            {
                var id = int.Parse(dr["ID"].ToString());
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
            //ROL_LISTAR tiene que tener: $@"select * from permiso p where p.permiso is null;";
            
            foreach (DataRow dr in tabla.Rows)
            {
                var id = int.Parse(dr["ID"].ToString());
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
            //USUARIO_PERMISO_LISTAR tiene que tener: $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";

            usuario.ListaDePermisos.Clear();

            foreach (DataRow dr in tabla.Rows)
            {
                int idpermiso = int.Parse(dr["ID"].ToString());
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

                    var f = TraerTodo("=" + idpermiso);
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
            foreach (var item in TraerTodo("=" + rol.Id))
            {
                rol.AgregarHijo(item);
            }
        }
    }
}
