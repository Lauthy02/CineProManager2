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
    public partial class Form_ABMGolosinas : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_GOLOSINA bllgolosina = new BLL_GOLOSINA();
        BE_GOLOSINA golosinaaux;
        bool operacion = false;

        public Form_ABMGolosinas()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
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
            golosinaaux = new BE_GOLOSINA();

            golosinaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            golosinaaux.Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            golosinaaux.Precio = float.Parse(dataGridView1.CurrentRow.Cells["Precio"].Value.ToString());

            if (MessageBox.Show($"¿Seguro que desea dar de baja el cine {golosinaaux.Nombre}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllgolosina.BorrarGolosina(golosinaaux);
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

            textBox_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox_Precio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            golosinaaux = new BE_GOLOSINA();

            golosinaaux.Nombre = textBox_Nombre.Text;
            golosinaaux.Precio = float.Parse(textBox_Precio.Text);

            if (operacion)
            {
                golosinaaux.Id = 0;
                bllgolosina.GuardarGolosina(golosinaaux);
                LlenarDataGrid();
            }
            else
            {
                golosinaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllgolosina.GuardarGolosina(golosinaaux);
                LlenarDataGrid();
            }

            textBox_Nombre.Text = "";
            textBox_Precio.Text = "";
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllgolosina.ListarGolosinas();
        }

        private void ControlesEn(bool trufal)
        {
            textBox_Nombre.Enabled = trufal;
            textBox_Precio.Enabled = trufal;
        }

        private void Form_ABMGolosinas_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMGolosinas_FormClosing(object sender, FormClosingEventArgs e)
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
