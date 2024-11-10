using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PEDIDO
    {
        DAL_MAPPER_PEDIDO dalmapperpedido = new DAL_MAPPER_PEDIDO();
        DAL_PEDIDO_GOLOSINA dalpedidogolosina = new DAL_PEDIDO_GOLOSINA();

        BLL_SERIALIZAR bllserializar = new BLL_SERIALIZAR();

        public void GuardarPedido(BE_PEDIDO bepedido)
        {
            if (bepedido.Id == 0)
            {
                bepedido.Id = (dalmapperpedido.TraerTodos().OrderByDescending(funcion => funcion.Id).FirstOrDefault()?.Id ?? 0) + 1;
                dalmapperpedido.Alta(bepedido);
                bllserializar.SerializarPedido(bepedido);
            }
            else
            {
                dalmapperpedido.Modificacion(bepedido);
            }
        }

        public void BorrarPedido(BE_PEDIDO bepedido)
        {
            dalmapperpedido.Baja(bepedido);
        }

        public List<BE_PEDIDO> BuscarPedido(BE_PEDIDO bepedido)
        {
            return dalmapperpedido.Buscar(bepedido);
        }

        public List<BE_PEDIDO> BuscarPedidoPorEstado(string estado)
        {
            return dalmapperpedido.BuscarEstado(estado);
        }

        public List<BE_PEDIDO> ListarPedidos()
        {
            return dalmapperpedido.TraerTodos();
        }
    }
}
