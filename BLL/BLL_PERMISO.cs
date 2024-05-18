using BE;
using BE.PERMISOS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PERMISO
    {
        DAL_PERMISO dalpermiso;

        public BLL_PERMISO()
        {
            dalpermiso = new DAL_PERMISO();
        }

        public bool ExistePermiso(BE_PERMISO permiso, int id)
        {
            bool existe = false;
            if (permiso.Id.Equals(id))
            {
                existe = true;
            }
            else
            {
                foreach (var item in permiso.ListaDeHijos)
                {
                    existe = ExistePermiso(item, id);
                    if (existe)
                    {
                        return true;
                    }
                }
            }
            return existe;
        }

        public Array BuscarTodosLosPermisos()
        {
            return dalpermiso.TraerTodosLosPermisos();
        }

        public int GuardarPermiso(BE_PERMISO permiso, bool esrol)
        {
            return dalpermiso.AltaPermiso(permiso, esrol);
        }

        public void GuardarRol(BE_ROL rol)
        {
            dalpermiso.AltaRol(rol);
        }

        public IList<BE_ACCION> BuscarTodasLasAcciones()
        {
            return dalpermiso.TraerTodasLasAcciones();
        }

        public IList<BE_ROL> BuscarTodosLosRoles()
        {
            return dalpermiso.TraerTodosLosRoles();
        }

        public IList<BE_PERMISO> BuscarTodo(string familia)
        {
            return dalpermiso.TraerTodo(familia);
        }

        public void LlenarUsuarioPermisos(BE_USUARIO usuario)
        {
            dalpermiso.LlenarUsuarioPermisos(usuario);
        }

        public void LlenarRolPermisos(BE_ROL rol)
        {
            dalpermiso.LlenarRolPermisos(rol);
        }
    }
}
