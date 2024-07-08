using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BLL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using BLL;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UI
{
    public partial class Form_ABMFunciones : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_SALA bllsala = new BLL_SALA();
        BLL_PELICULA bllpelicula = new BLL_PELICULA();
        BLL_FUNCION bllfuncion = new BLL_FUNCION();
        BE_FUNCION funcionaux;
        bool operacion = false;

        public Form_ABMFunciones()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxSalas();
            LlenarComboBoxPeliculas();
            LlenarComboBoxHorarios();
            LlenarDataGrid();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos");

            ControlesEn(true);

            button_Baja.Enabled = false;
            button_Modificacion.Enabled = false;
            button_Guardar.Enabled = true;

            operacion = true;
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            funcionaux = new BE_FUNCION();

            funcionaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

            if (MessageBox.Show($"¿Seguro que desea dar de baja la funcion {funcionaux.Id}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllfuncion.BorrarFuncion(funcionaux);
                LlenarDataGrid();
            }
        }

        private void button_Modificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifique los datos");

            ControlesEn(true);

            button_Alta.Enabled = false;
            button_Baja.Enabled = false;
            button_Guardar.Enabled = true;

            comboBox_Pelicula.Text = dataGridView1.CurrentRow.Cells["Pelicula"].Value.ToString();
            comboBox_Horarios.Text = dataGridView1.CurrentRow.Cells["Horario"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            funcionaux = new BE_FUNCION();

            funcionaux.Pelicula.Id = ((BE_PELICULA)comboBox_Pelicula.SelectedItem).Id;
            funcionaux.Horario = (DateTime)comboBox_Horarios.SelectedItem;

            if (operacion)
            {
                funcionaux.Id = 0;
                bllfuncion.GuardarFuncion((BE_SALA)comboBox_Salas.SelectedItem, funcionaux);
                LlenarComboBoxSalas();
                LlenarDataGrid();
            }
            else
            {
                funcionaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllfuncion.GuardarFuncion((BE_SALA)comboBox_Salas.SelectedItem, funcionaux);
                LlenarComboBoxSalas();
                LlenarDataGrid();
            }

            comboBox_Pelicula.Text = "";
            comboBox_Horarios.Text = "";
        }

        private void comboBox_Salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            BE_SALA salaaux = (BE_SALA)comboBox_Salas.SelectedItem;
            if (salaaux != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = salaaux.ListaDeFunciones;
            }
        }

        public void LlenarComboBoxSalas()
        {
            comboBox_Salas.DataSource = null;
            comboBox_Salas.DataSource = bllsala.ListarSalas();
            comboBox_Salas.DisplayMember = "Id";
        }

        public void LlenarComboBoxPeliculas()
        {
            comboBox_Pelicula.DataSource = null;
            comboBox_Pelicula.DataSource = bllpelicula.ListarPeliculas();
        }

        public void LlenarComboBoxHorarios()
        {
            List<DateTime> listadehorarios = new List<DateTime>();

            DateTime h1 = new DateTime(1900, 1, 1, 12, 10, 0);
            DateTime h2 = new DateTime(1900, 1, 1, 13, 40, 0);
            DateTime h3 = new DateTime(1900, 1, 1, 16, 0, 0);
            DateTime h4 = new DateTime(1900, 1, 1, 16, 50, 0);
            DateTime h5 = new DateTime(1900, 1, 1, 18, 20, 0);

            listadehorarios.Add(h1);
            listadehorarios.Add(h2);
            listadehorarios.Add(h3);
            listadehorarios.Add(h4);
            listadehorarios.Add(h5);

            comboBox_Horarios.DataSource = listadehorarios;
            comboBox_Horarios.DisplayMember = "TimeOfDay";
        }

        private void Form_ABMFunciones_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMFunciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma) 
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
        private void ControlesEn(bool trufal)
        {
            comboBox_Pelicula.Enabled = trufal;
            comboBox_Horarios.Enabled = trufal;
        }
    }
}
