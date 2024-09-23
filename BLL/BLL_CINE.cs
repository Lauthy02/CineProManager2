using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_CINE
    {
        DAL_MAPPER_CINE dalmappercine = new DAL_MAPPER_CINE();

        public void GuardarCine(BE_CINE becine)
        {
            if (becine.Id == 0)
            {
                dalmappercine.Alta(becine);
            }
            else
            {
                dalmappercine.Modificacion(becine);
            }
        }

        public void BorrarCine(BE_CINE becine)
        {
            dalmappercine.Baja(becine);
        }

        public List<BE_CINE> BuscarCine(BE_CINE becine)
        {
            return dalmappercine.Buscar(becine);
        }

        public List<BE_CINE> ListarCines()
        {
            return dalmappercine.TraerTodos();
        }
    }
}
