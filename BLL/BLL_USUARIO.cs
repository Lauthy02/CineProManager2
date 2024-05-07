using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_USUARIO
    {
        DAL.DAL_MAPPER_USUARIO dalmapperusuario = new DAL.DAL_MAPPER_USUARIO();

        public void GuardarUsuario(BE_USUARIO beusuario)
        {
            if (beusuario.Id == 0)
            {
                dalmapperusuario.Alta(beusuario);
            }
            else
            {
                dalmapperusuario.Modificacion(beusuario);
            }
        }

        public void BorrarUsuario(BE.BE_USUARIO beusuario)
        {
            dalmapperusuario.Baja(beusuario);
        }

        public List<BE_USUARIO> BuscarUsuario(BE.BE_USUARIO beusuario)
        {
            return dalmapperusuario.Buscar(beusuario);
        }

        public List<BE_USUARIO> ListarUsuarios()
        {
            return dalmapperusuario.TraerTodos();
        }
    }
}
