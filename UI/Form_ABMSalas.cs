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
        BE_SALA salaaux;
        bool operacion = false;

        public Form_ABMSalas()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxCines();
            LlenarComboBoxSalaTipos();
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
            salaaux = new BE_SALA();

            salaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            salaaux.NumeroDeSala = int.Parse(dataGridView1.CurrentRow.Cells["Numerodesala"].Value.ToString());

            if (MessageBox.Show($"¿Seguro que desea dar de baja el cine {salaaux.NumeroDeSala}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllsala.BorrarSala(salaaux);
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

            textBox_SalaCapacidad.Text = dataGridView1.CurrentRow.Cells["Capacidad"].Value.ToString();
            textBox_NroSala.Text = dataGridView1.CurrentRow.Cells["Numerodesala"].Value.ToString();
            comboBox_SalaFormato.Text = dataGridView1.CurrentRow.Cells["Formato"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            salaaux = new BE_SALA();

            salaaux.Capacidad = int.Parse(textBox_SalaCapacidad.Text);
            salaaux.NumeroDeSala = int.Parse(textBox_NroSala.Text);
            salaaux.Formato = (BE_SALA_FORMATO_ENUM)Enum.Parse(typeof(BE_SALA_FORMATO_ENUM), comboBox_SalaFormato.SelectedItem.ToString());

            if (operacion)
            {
                salaaux.Id = 0;
                bllsala.GuardarSala((BE_CINE)comboBox_Cines.SelectedItem, salaaux);
                LlenarComboBoxCines();
                LlenarDataGrid();
            }
            else
            {
                salaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllsala.GuardarSala((BE_CINE)comboBox_Cines.SelectedItem, salaaux);
                LlenarComboBoxCines();
                LlenarDataGrid();
            }

            textBox_SalaCapacidad.Text = "";
            textBox_NroSala.Text = "";
            comboBox_SalaFormato.Text = "";
        }

        private void ControlesEn(bool trufal)
        {
            textBox_SalaCapacidad.Enabled = trufal;
            textBox_NroSala.Enabled = trufal;
            comboBox_SalaFormato.Enabled = trufal;
        }

        private void comboBox_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            BE_CINE cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            if (cineaux != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cineaux.ListaDeSalas;
            }
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
