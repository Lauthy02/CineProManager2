using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_SERIALIZAR
    {
        DAL_SERIALZIAR dalserializar = new DAL_SERIALZIAR();

        private string pathPedido = "PedidoJSON.json";

        public void SerializarPedido(BE_PEDIDO bepedido)
        {
            dalserializar.Serializar<BE_PEDIDO>(bepedido, pathPedido);
            MessageBox.Show("Objeto serializado:");
        }

        public BE_PEDIDO DeserializarPedido()
        {
            MessageBox.Show("Objeto deserializado:");
            return dalserializar.Deserializar<BE_PEDIDO>(pathPedido);
        }
    }
}
