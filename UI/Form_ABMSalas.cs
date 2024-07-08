using BE;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
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

namespace UI
{
    public partial class Form_ABMSalas : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_CINE bllcine = new BLL_CINE();
        BLL_SALA bllsala = new BLL_SALA();

        public Form_ABMSalas()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxCines();
            LlenarComboBoxSalaTipos();
        }

        private void comboBox_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            BE_CINE cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            dataGridView1.DataSource = cineaux.ListaDeSalas;
        }

        private void LlenarComboBoxSalaTipos()
        {
            var formatos = Enum.GetValues(typeof(BE_SALA_FORMATO_ENUM));
            foreach (var formato in formatos)
            {
                comboBox_SalaFormato.Items.Add(formato.ToString());
            }
        }

        private void LlenarComboBoxCines()
        {
            comboBox_Cines.DataSource = null;
            comboBox_Cines.DataSource = bllcine.ListarCines();
        }

        private void Form_ABMSalas_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMSalas_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
