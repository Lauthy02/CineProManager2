using BE.BITACORAYCAMBIOS;
using BE;
using BE.MULTIIDOMA;
using BLL.BITACORAYCAMBIOS;
using BLL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE.MULTIIDIOMA;

namespace UI
{
    public partial class Form_PedidoReservar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_PEDIDO bllpedido = new BLL_PEDIDO();
        BLL_GOLOSINA bllgolosina = new BLL_GOLOSINA();
        BLL_PEDIDO_GOLOSINA bllpedidogolosina = new BLL_PEDIDO_GOLOSINA();

        public Form_PedidoReservar()
        {
            InitializeComponent();
            LlenarListboxGolosinas();
            InicializarDataGridPedido();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            BE_PEDIDO pedido = new BE_PEDIDO();
            pedido.Id = 0;
            pedido.Cliente = BE_SESION.ObtenerInstancia.Usuario;
            pedido.Fecha = DateTime.Now;
            pedido.Estado = BE_PEDIDO_ESTADO_ENUM.Reservado;
            pedido.MontoTotal = CalcularPrecioTotal();
            bllpedido.GuardarPedido(pedido);

            foreach (DataGridViewRow row in dataGridView_Pedido.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    string nombreGolosina = row.Cells["Nombre"].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    // Buscar la golosina en la lista de golosinas
                    BE_GOLOSINA golosina = bllgolosina.ListarGolosinas().FirstOrDefault(g => g.Nombre == nombreGolosina);

                    if (golosina != null)
                    {
                        bllpedidogolosina.GuardarPedidoGolosina(pedido, golosina, cantidad);
                    }
                }
            }
            MessageBox.Show("Pedido reservado");
            dataGridView_Pedido.Rows.Clear();
        }

        private void button_CalcularPedido_Click(object sender, EventArgs e)
        {
            label_PrecioTotal.Text = "Precio Total: " + CalcularPrecioTotal().ToString("C2");
        }

        private void button_AgregarGolosina_Click(object sender, EventArgs e)
        {
            if (listBox_Golosinas.SelectedItem != null)
            {
                BE_GOLOSINA golosinaSeleccionada = (BE_GOLOSINA)listBox_Golosinas.SelectedItem;
                AgregarGolosinaAlPedido(golosinaSeleccionada);
            }
        }

        private void button_QuitarGolosina_Click(object sender, EventArgs e)
        {
            if (dataGridView_Pedido.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Pedido.SelectedRows[0];
                int cantidadActual = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);

                if (cantidadActual > 1)
                {
                    selectedRow.Cells["Cantidad"].Value = cantidadActual - 1;
                }
                else
                {
                    dataGridView_Pedido.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una golosina para quitar del pedido.");
            }
        }

        private void listBox_Golosinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_GOLOSINA golosinaaux = (BE_GOLOSINA)listBox_Golosinas.SelectedItem;
            label_NombreGolosina.Text = "Nombre: " + golosinaaux.Nombre;
            label_PrecioUnitario.Text = "Precio: " + golosinaaux.Precio.ToString();
        }

        private void LlenarListboxGolosinas()
        {
            listBox_Golosinas.DataSource = null;
            listBox_Golosinas.DataSource = bllgolosina.ListarGolosinas();
        }

        private float CalcularPrecioTotal()
        {

            float precioTotal = 0;

            foreach (DataGridViewRow row in dataGridView_Pedido.Rows)
            {
                if (row.Cells["Cantidad"].Value != null && row.Cells["Precio"].Value != null)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    float precio = Convert.ToSingle(row.Cells["Precio"].Value);
                    precioTotal += cantidad * precio;
                }
            }

            return precioTotal;
        }

        private void InicializarDataGridPedido()
        {
            dataGridView_Pedido.Columns.Add("Nombre", "Nombre");
            dataGridView_Pedido.Columns.Add("Cantidad", "Cantidad");
            dataGridView_Pedido.Columns.Add("Precio", "Precio");
        }

        private void AgregarGolosinaAlPedido(BE_GOLOSINA golosina)
        {
            bool golosinaExistente = false;

            foreach (DataGridViewRow row in dataGridView_Pedido.Rows)
            {
                if (row.Cells["Nombre"].Value != null)
                {
                    if (row.Cells["Nombre"].Value.ToString() == golosina.Nombre)
                    {
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        row.Cells["Cantidad"].Value = cantidadActual + 1;
                        row.Cells["Precio"].Value = golosina.Precio;
                        golosinaExistente = true;
                        break;
                    }
                }
            }

            if (!golosinaExistente)
            {
                dataGridView_Pedido.Rows.Add(golosina.Nombre, 1, golosina.Precio);
            }
        }

        private void Form_PedidoReservar_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_PedidoReservar_FormClosing(object sender, FormClosingEventArgs e)
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
