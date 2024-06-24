using BE;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BE.SESION;
using BLL.MULTIIDIOMA;
using DAL;
using DAL.MULTIIDIOMA;
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
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();

        public BE_LOGIN_RESULTADO_ENUM LogIn(string nombredeusuario, string contrasenia)
        {
            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                throw new Exception("Ya hay un usuario logueado");
            }
            else
            {
                var usuario = dalmapperusuario.Buscar(new BE_USUARIO { NombreDeUsuario = nombredeusuario, Contrasenia = contrasenia });
                if (usuario.Count != 0)
                {
                    BE_USUARIO usuarioaux = usuario[0];
                    if (usuarioaux.Contrasenia == contrasenia)
                    {
                        new DAL_PERMISO().LlenarUsuarioPermisos(usuarioaux);
                        //new DAL_MAPPER_IDIOMA().LlenarUsuarioIdioma(usuarioaux);
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
                NotificarObservadoresForms(blltraductor.ObtenerIdiomaPorDefecto());
            }
            else
            {
                throw new Exception("No hay un usuario logueado");
            }
        }

        public void AgregarObservadorForm(BE_IOBSERVERIDIOMA observador)
        {
            BE_SESION.Observadores.Add(observador);
        }

        public void QuitarObservadorForm(BE_IOBSERVERIDIOMA observador)
        {
            BE_SESION.Observadores.Remove(observador);
        }

        private  void NotificarObservadoresForms(BE_IDIOMA idioma)
        {
            foreach (var observador in BE_SESION.Observadores)
            {
                observador.ActualizarIdioma(idioma);
            }
        }

        public void CambiarIdioma(BE_IDIOMA idioma)
        {
            BE_SESION.ObtenerInstancia.Usuario.Idioma = idioma;
            NotificarObservadoresForms(idioma);
        }
    }
}
