using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GOLOSINA
    {
        DAL_MAPPER_GOLOSINA dalmappergolosina = new DAL_MAPPER_GOLOSINA();

        public void GuardarGolosina(BE_GOLOSINA begolosina)
        {
            if (begolosina.Id == 0)
            {
                dalmappergolosina.Alta(begolosina);
            }
            else
            {
                dalmappergolosina.Modificacion(begolosina);
            }
        }

        public void BorrarGolosina(BE_GOLOSINA begolosina)
        {
            dalmappergolosina.Baja(begolosina);
        }

        public List<BE_GOLOSINA> BuscarGolosina(BE_GOLOSINA begolosina)
        {
            return dalmappergolosina.Buscar(begolosina);
        }

        public List<BE_GOLOSINA> ListarGolosinas()
        {
            return dalmappergolosina.TraerTodos();
        }
    }
}
