using BE;
using BE.SESION;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SESION
    {
        DAL_MAPPER_USUARIO dalmapperusuario = new DAL_MAPPER_USUARIO();

        public BE_LOGIN_RESULTADO_ENUM LogIn(string nombredeusuario, string contrasenia)
        {
            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                throw new Exception("Ya hay un usuario logueado");
            }
            else
            {
                var usuario = dalmapperusuario.Buscar(new BE_USUARIO { NombreDeUsuario = nombredeusuario, Contrasenia = contrasenia });
                if (usuario != null)
                {
                    BE_USUARIO usuarioaux = usuario[0];
                    if (usuarioaux.Contrasenia == contrasenia)
                    {
                        //new DAL_PERMISO().LlenarUsuarioPermisos(usuarioaux);
                        BE_SESION.ObtenerInstancia.LogIn(usuarioaux);
                        return BE_LOGIN_RESULTADO_ENUM.LogInCorrecto;
                    }
                    else
                    {
                        throw new BE_LOGIN_EXCEPCION(BE_LOGIN_RESULTADO_ENUM.ContraseniaIncorrecta);
                    }
                }
                else
                {
                    throw new BE_LOGIN_EXCEPCION(BE_LOGIN_RESULTADO_ENUM.NombreDeUsuarioIncorrecto);
                }
            }
        }

        public void LogOut()
        {
            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                BE_SESION.ObtenerInstancia.LogOut();
            }
            else
            {
                throw new Exception("No hay un usuario logueado");
            }
        }
    }
}
