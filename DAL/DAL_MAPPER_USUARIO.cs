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
        DAL_ENCRIPTADOR encriptador;

        public DAL_MAPPER_USUARIO()
        {
            acceso.AbrirConexion();
            encriptador = new DAL_ENCRIPTADOR();
        }

        public override int Alta(BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p); 
            p = acceso.CrearParametro("@contrasenia", encriptador.EncriptarMD5(entidad.Contrasenia));
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@apellido", entidad.Apellido);
            parametros.Add(p);
            p = acceso.CrearParametro("@correo", entidad.Correo);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_INSERTAR", parametros);
            //INSERT INTO USUARIOS VALUES (@nombredeusuario, @contrasenia, @nombre, @apellido, @correo)
            return res;
        }

        public override int Baja(BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_BORRAR", parametros);
            //DELETE FROM USUARIOS WHERE id = @id
            return res;
        }

        public override int Modificacion(BE_USUARIO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.Id);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p);
            p = acceso.CrearParametro("@contrasenia", encriptador.EncriptarMD5(entidad.Contrasenia));
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@apellido", entidad.Apellido);
            parametros.Add(p);
            p = acceso.CrearParametro("@correo", entidad.Correo);
            parametros.Add(p);

            int res = acceso.Escribir("USUARIO_EDITAR", parametros);
            /*
            update USUARIOS SET 
                nombredeusuario = @nombredeusuario, 
                contrasenia = @contrasenia,
                nombre = @nombre,
                apellido = @apellido,
                correo = @correo
            WHERE id = @id
            */
            return res;
        }

        public List<BE_USUARIO> Buscar(BE_USUARIO entidad)
        {
            List<BE_USUARIO> usuarios = new List<BE_USUARIO>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombredeusuario", entidad.NombreDeUsuario);
            parametros.Add(p);
            p = acceso.CrearParametro("@contrasenia", encriptador.EncriptarMD5(entidad.Contrasenia));
            parametros.Add(p);
            //"DwN1hMmef9T0+MWVUPj1Bw=="
            DataTable tabla = acceso.Leer("USUARIO_BUSCAR", parametros);
            //SELECT * FROM USUARIOS WHERE nombredeusuario = @nombredeusuario AND contrasenia = @contrasenia
            foreach (DataRow dr in tabla.Rows)
            {
                usuarios.Add(Convertir(dr));
            }
            return usuarios;
        }

        public override List<BE_USUARIO> TraerTodos()
        {
            List<BE_USUARIO> usuarios = new List<BE_USUARIO>();
            DataTable tabla = acceso.Leer("USUARIO_LISTAR", null);
            //SELECT * FROM USUARIOS
            foreach (DataRow dr in tabla.Rows)
            {
                usuarios.Add(Convertir(dr));
            }
            return usuarios;
        }

        internal override BE_USUARIO Convertir(DataRow registro)
        {
            BE_USUARIO usuario = new BE_USUARIO();
            usuario.Id = int.Parse(registro["id"].ToString());
            usuario.NombreDeUsuario = registro["nombredeusuario"].ToString();
            usuario.Contrasenia = encriptador.DesencriptarMD5(registro["contrasenia"].ToString());
            usuario.Nombre = registro["nombre"].ToString();
            usuario.Apellido = registro["apellido"].ToString();
            usuario.Correo = registro["correo"].ToString();
            return usuario;
        }

        public void AltaPermisos(BE_USUARIO usuario)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter p = acceso.CrearParametro("@id", usuario.Id);
                parametros.Add(p);

                var res = acceso.Escribir("USUARIOS_PERMISOS_BORRAR", parametros);
                //DELETE FROM USUARIOS_PERMISOS WHERE idusuario = @id

                foreach (var item in usuario.ListaDePermisos)
                {
                    List<SqlParameter> parametros2 = new List<SqlParameter>();
                    SqlParameter p2 = acceso.CrearParametro("@idusuario", usuario.Id);
                    parametros2.Add(p2);
                    p2 = acceso.CrearParametro("@idpermiso", item.Id);
                    parametros2.Add(p2);

                    var res2 = acceso.Escribir("USUARIOS_PERMISOS_INSERTAR", parametros2);
                    //INSERT INTO USUARIOS_PERMISOS VALUES (@idusuario, @idpermiso)
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
