using BE;
using BE.MULTIIDOMA;
using DAL;
using DAL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MULTIIDIOMA
{
    public class BLL_IDIOMA
    {
        DAL_MAPPER_IDIOMA dalmapperidioma = new DAL_MAPPER_IDIOMA();

        public void GuardarIdioma(BE_IDIOMA beidioma)
        {
            if (beidioma.Id == 0)
            {
                dalmapperidioma.Alta(beidioma);
            }
            else
            {
                dalmapperidioma.Modificacion(beidioma);
            }
        }

        public void BorrarIdioma(BE_IDIOMA beidioma)
        {
            dalmapperidioma.Baja(beidioma);
        }

        public List<BE_IDIOMA> BuscarIdioma(BE_IDIOMA beidioma)
        {
            return dalmapperidioma.Buscar(beidioma);
        }

        public List<BE_IDIOMA> ListarIdiomas()
        {
            return dalmapperidioma.TraerTodos();
        }


    }
}
