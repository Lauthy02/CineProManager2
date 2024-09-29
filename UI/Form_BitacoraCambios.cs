using BE.MULTIIDOMA;
using BLL.BITACORAYCAMBIOS;
using BLL;
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
using BE;
using BE.MULTIIDIOMA;
using BE.BITACORAYCAMBIOS;

namespace UI
{
    public partial class Form_BitacoraCambios : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();

        BLL_BITACORA_CAMBIOS_ENTRADA bllbitacoracambios = new BLL_BITACORA_CAMBIOS_ENTRADA();

        public Form_BitacoraCambios()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarDataGrid();
        }

        private void button_RecomponerEstado_Click(object sender, EventArgs e)
        {
            BE_BITACORA_CAMBIOS_ENTRADA entradabitacoraaux = new BE_BITACORA_CAMBIOS_ENTRADA();

            entradabitacoraaux = (BE_BITACORA_CAMBIOS_ENTRADA)dataGridView1.CurrentRow.DataBoundItem;
            bllbitacoracambios.RecomponerEstado(entradabitacoraaux);
            MessageBox.Show("Estado del registro cambiado con éxito");
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllbitacoracambios.ListarBitacoraCambios();
        }

        private void Form_BitacoraCambios_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_BitacoraCambios_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
