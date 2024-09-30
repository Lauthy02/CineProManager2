using BE;
using BE.BITACORAYCAMBIOS;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BLL;
using BLL.BITACORAYCAMBIOS;
using BLL.DIGITOVERIFICADOR;
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

namespace UI
{
    public partial class Form_EntradasPagar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_ENTRADA bllentdada = new BLL_ENTRADA();
        BLL_DIGITOVERIFICADOR blldigitoverificador = new BLL_DIGITOVERIFICADOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_BITACORA_CAMBIOS_ENTRADA bllbitacoracambiosentrada = new BLL_BITACORA_CAMBIOS_ENTRADA();

        public Form_EntradasPagar()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarDataGrid();
        }

        private void button_PagarEntradas_Click(object sender, EventArgs e)
        {
            BE_ENTRADA entradaaux = new BE_ENTRADA();
            BE_BITACORA_CAMBIOS_ENTRADA bitacoracambiosentradaaux = new BE_BITACORA_CAMBIOS_ENTRADA();

            entradaaux = (BE_ENTRADA)dataGridView1.CurrentRow.DataBoundItem;
            if (entradaaux != null)
            {
                entradaaux.Estado = BE_ENTRADA_ESTADO_ENUM.Pagada;
                //entradaaux.DigitoVerificador = blldigitoverificador.CalcularDVH(entradaaux);

                bllentdada.GuardarEntrada(entradaaux);

                bitacoracambiosentradaaux.UsuarioQueModifica = BE_SESION.ObtenerInstancia.Usuario;
                bitacoracambiosentradaaux.FechaDeCambio = DateTime.Now;
                bitacoracambiosentradaaux.Activo = true;
                bitacoracambiosentradaaux.B_Entrada = entradaaux;

                bllbitacoracambiosentrada.GuardarEntrada(bitacoracambiosentradaaux);

                MessageBox.Show("Entrada pagada correctamente");
                MessageBox.Show("Entrada disponible para emitir");
                LlenarDataGrid();
            }
        }

        private void LlenarDataGrid()
        { 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllentdada.BuscarEntradaPorEstado(BE_ENTRADA_ESTADO_ENUM.Reservada.ToString());
        }

        private void Form_EntradasPagar_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_EntradasPagar_FormClosing(object sender, FormClosingEventArgs e)
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
