using BE.PERMISOS;
using System;
using BE.MULTIIDIOMA;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.MULTIIDOMA;

namespace BE
{
    public class BE_SESION
    {
        //Esta clase me sirve para guardar el usuario logueado y verificar que solo haya una instancia

        private static BE_SESION instancia;
        private static Object bloqueo = new Object();

        public BE_SESION()
        { 
            observadores = new List<BE_IOBSERVERIDIOMA>();
        }

        private BE_USUARIO usuario;
        public BE_USUARIO Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private static List<BE_IOBSERVERIDIOMA> observadores;
        public static List<BE_IOBSERVERIDIOMA> Observadores
        {
            get { return observadores; }
            set { observadores = value; }
        }

        public static BE_SESION ObtenerInstancia
        {
            get
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                    {
                        instancia = new BE_SESION();
                    }
                }
                return instancia;
            }
        }

        bool estaEnElRol(BE_PERMISO permiso, BE_PERMISO_TIPO_ENUM permisotipoenum, bool existe)
        {
            if (permiso.PermisoTipoEnum.Equals(permisotipoenum))
            {
                existe = true;
            }
            else
            {
                foreach (var hijo in permiso.ListaDeHijos)
                {
                    existe = estaEnElRol(hijo, permisotipoenum, existe);
                    if (existe)
                    {
                        return true;
                    }
                }
            }
            return existe;
        }

        public bool EstaEnElRol(BE_PERMISO_TIPO_ENUM permisotipoenum)
        {
            if (Usuario == null)
            {
                return false;
            }
            bool existe = false;
            foreach (var item in Usuario.ListaDePermisos)
            {
                if (item.PermisoTipoEnum.Equals(permisotipoenum))
                {
                    return true;
                }
                else
                {
                    existe = estaEnElRol(item, permisotipoenum, existe);
                    if (existe)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void LogIn(BE_USUARIO usuario)
        {
            Usuario = usuario;
        }

        public void LogOut()
        {
            Usuario = null;
        }

        public bool Logueado()
        {
            return Usuario != null;
        }
    }
}
