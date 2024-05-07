using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MAPPER_USUARIO : DAL_MAPPER<BE_USUARIO>
    {
        public DAL_MAPPER_USUARIO()
        {
            acceso.AbrirConexion();
        }

        /*
        ~DAL_MAPPER_USUARIO()
        {
            //Comento el destructor porque al cerrar la aplicación ocurre un error
            acceso.CerrarConexion();
        }
        */

        public override int Alta(BE.BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p);
            p = acceso.CrearParametro("@contrasenia", entidad.Contrasenia);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@apellido", entidad.Apellido);
            parametros.Add(p);
            p = acceso.CrearParametro("@correo", entidad.Correo);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_INSERTAR", parametros);
            return res;
        }

        public override int Baja(BE.BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_BORRAR", parametros);
            return res;
        }

        public override int Modificacion(BE.BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p);
            p = acceso.CrearParametro("@contrasenia", entidad.Contrasenia);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@apellido", entidad.Apellido);
            parametros.Add(p);
            p = acceso.CrearParametro("@correo", entidad.Correo);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_EDITAR", parametros);
            return res;
        }

        public List<BE_USUARIO> Buscar(BE.BE_USUARIO entidad)
        {
            List<BE.BE_USUARIO> usuarios = new List<BE.BE_USUARIO>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p);
            p = acceso.CrearParametro("@contrasenia", entidad.Contrasenia);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("USUARIO_BUSCAR", parametros);
            foreach (DataRow dr in tabla.Rows)
            {
                usuarios.Add(Convertir(dr));
            }
            return usuarios;
        }

        public override List<BE.BE_USUARIO> TraerTodos()
        {
            List<BE.BE_USUARIO> usuarios = new List<BE.BE_USUARIO>();
            DataTable tabla = acceso.Leer("USUARIO_LISTAR", null);
            foreach (DataRow dr in tabla.Rows)
            {
                usuarios.Add(Convertir(dr));
            }
            return usuarios;
        }

        internal override BE.BE_USUARIO Convertir(DataRow registro)
        {
            BE_USUARIO usuario = new BE_USUARIO();
            usuario.Id = int.Parse(registro["id"].ToString());
            usuario.NombreDeUsuario = registro["nombredeusuario"].ToString();
            usuario.Contrasenia = registro["contrasenia"].ToString();
            usuario.Nombre = registro["nombre"].ToString();
            usuario.Apellido = registro["apellido"].ToString();
            usuario.Correo = registro["correo"].ToString();
            return usuario;
        }
    }
}
