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
using BE;
using BE.MULTIIDOMA;

namespace UI
{
    public partial class Form_ABMIdioma : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_IDIOMA bllidioma = new BLL_IDIOMA();
        BE_IDIOMA idiomaaux;
        bool operacion = false;

        public Form_ABMIdioma()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarDataGrid();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos");

            ControlesEn(true);
            comboBox1.Enabled = false;

            button_Baja.Enabled = false;
            button_Modificacion.Enabled = false;
            button_Guardar.Enabled = true;

            operacion = true;
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            idiomaaux = new BE_IDIOMA();

            idiomaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            idiomaaux.Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea dar de baja el idioma {idiomaaux.Nombre}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllidioma.BorrarIdioma(idiomaaux);
                LlenarDataGrid();
            }
        }

        private void button_Modificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifique los datos");

            ControlesEn(true);
            textBox_Nombre.Enabled = false;

            button_Alta.Enabled = false;
            button_Baja.Enabled = false;
            button_Guardar.Enabled = true;

            textBox_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["ListoParaUsar"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            idiomaaux = new BE_IDIOMA();

            idiomaaux.Nombre = textBox_Nombre.Text;
            if (comboBox1.Text != null)
            {
                if (comboBox1.Text == "Si")
                {
                    idiomaaux.ListoParaUsar = true;
                }
                else if (comboBox1.Text == "No")
                {
                    idiomaaux.ListoParaUsar = false;
                }
            }
            else
            {
                idiomaaux.ListoParaUsar = false;
            }

            if (operacion)
            {
                idiomaaux.Id = 0;
                bllidioma.GuardarIdioma(idiomaaux);
                LlenarDataGrid();
            }
            else
            {
                idiomaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllidioma.GuardarIdioma(idiomaaux);
                LlenarDataGrid();
            }

            textBox_Nombre.Text = "";
            comboBox1.Text = "";
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllidioma.ListarIdiomas();
        }

        private void ControlesEn(bool trufal)
        {
            textBox_Nombre.Enabled = trufal;
            comboBox1.Enabled = trufal;
        }

        private void Form_ABMIdioma_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
