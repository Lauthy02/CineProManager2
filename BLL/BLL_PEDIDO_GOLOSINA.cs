using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PEDIDO_GOLOSINA
    {
        DAL_PEDIDO_GOLOSINA dalpedidogolosina = new DAL_PEDIDO_GOLOSINA();

        public void GuardarPedidoGolosina(BE_PEDIDO bepedido, BE_GOLOSINA begolosina, int cantidad)
        {
            dalpedidogolosina.Alta(bepedido, begolosina, cantidad);
        }
    }
}
