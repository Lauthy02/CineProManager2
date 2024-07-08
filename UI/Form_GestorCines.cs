using BE.MULTIIDIOMA;
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
using BE.MULTIIDOMA;
using BE;

namespace UI
{
    public partial class Form_GestorCines : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_CINE bllcine = new BLL_CINE();

        public Form_GestorCines()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxCines();
        }

        private void comboBox_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListBoxCartelera();
            LlenarListBoxSalas();
        }

        public void LlenarComboBoxCines()
        {
            comboBox_Cines.DataSource = null;
            comboBox_Cines.DataSource = bllcine.ListarCines();
        }

        public void LlenarListBoxCartelera()
        {
            BE_CINE cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            listBox_Cartelera.DataSource = null;
            listBox_Cartelera.DataSource = cineaux.Cartelera.ListaDePeliculas;
        }

        public void LlenarListBoxSalas()
        {
            BE_CINE cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            listBox_Salas.DataSource = null;
            listBox_Salas.DataSource = cineaux.ListaDeSalas;
            listBox_Salas.DisplayMember = "Id";
        }

        private void listBox_Salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_SALA salaaux = (BE_SALA)listBox_Salas.SelectedItem;
            if (salaaux != null)
            {
                listBox_Funciones.DataSource = null;
                listBox_Funciones.DataSource = salaaux.ListaDeFunciones;
                listBox_Funciones.DisplayMember = "Id";
            }
        }

        private void Form_GestorCines_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorCines_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma) //Implementación de la interfaz BE_IOBSERVERIDIOMA
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
