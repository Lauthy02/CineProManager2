using BLL.BITACORAYCAMBIOS;
using BLL.MULTIIDIOMA;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BE;
using BE.BITACORAYCAMBIOS;

namespace UI
{
    public partial class Form_PedidoPagar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_PEDIDO bllpedido = new BLL_PEDIDO();

        public Form_PedidoPagar()
        {
            InitializeComponent();
            LlenarDataGrid();
        }

        private void button_PagarPedido_Click(object sender, EventArgs e)
        {
            BE_PEDIDO pedidoaux = new BE_PEDIDO();

            pedidoaux = (BE_PEDIDO)dataGridView1.CurrentRow.DataBoundItem;
            if (pedidoaux != null)
            {
                pedidoaux.Estado = BE_PEDIDO_ESTADO_ENUM.Pagado;

                bllpedido.GuardarPedido(pedidoaux);

                MessageBox.Show("Pedido pagado correctamente");
                LlenarDataGrid();
            }
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllpedido.BuscarPedidoPorEstado(BE_PEDIDO_ESTADO_ENUM.Reservado.ToString());
        }

        private void Form_PedidoPagar_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_PedidoPagar_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Cerrar {this.Text}"));
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
