using BE;
using BE.BITACORAYCAMBIOS;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BLL;
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

namespace UI
{
    public partial class Form_ABMUsuarios : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_IDIOMA bllidioma = new BLL_IDIOMA();
        BLL_USUARIO bllusuario = new BLL_USUARIO();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BE_USUARIO usuarioaux;
        bool operacion = false;

        public Form_ABMUsuarios()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxIdioma();
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
            usuarioaux = new BE_USUARIO();

            usuarioaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            usuarioaux.Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            usuarioaux.Apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea dar de baja al usuario {usuarioaux.Nombre} {usuarioaux.Apellido}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllusuario.BorrarUsuario(usuarioaux);
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

            textBox_NombreDeUsuario.Text = dataGridView1.CurrentRow.Cells["NombreDeUsuario"].Value.ToString();
            textBox_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox_Apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            textBox_Contrasenia.Text = dataGridView1.CurrentRow.Cells["Contrasenia"].Value.ToString();
            textBox_Correo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            usuarioaux = new BE_USUARIO();

            usuarioaux.NombreDeUsuario = textBox_NombreDeUsuario.Text;
            usuarioaux.Nombre = textBox_Nombre.Text;
            usuarioaux.Apellido = textBox_Apellido.Text;
            usuarioaux.Contrasenia = textBox_Contrasenia.Text;
            usuarioaux.Correo = textBox_Correo.Text;
            usuarioaux.Idioma = (BE_IDIOMA)comboBox_Idioma.SelectedItem;

            if (operacion)
            {
                usuarioaux.Id = 0;
                bllusuario.GuardarUsuario(usuarioaux);
                LlenarDataGrid();
            }
            else
            {
                usuarioaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllusuario.GuardarUsuario(usuarioaux);
                LlenarDataGrid();
            }

            textBox_NombreDeUsuario.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_Contrasenia.Text = "";
            textBox_Correo.Text = "";
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllusuario.ListarUsuarios();
        }

        private void LlenarComboBoxIdioma()
        {
            comboBox_Idioma.DataSource = null;
            comboBox_Idioma.DataSource = bllidioma.ListarIdiomas();
            comboBox_Idioma.DisplayMember = "Nombre";
        }

        private void ControlesEn(bool trufal)
        {
            textBox_NombreDeUsuario.Enabled = trufal;
            textBox_Nombre.Enabled = trufal;
            textBox_Apellido.Enabled = trufal;
            textBox_Contrasenia.Enabled = trufal;
            textBox_Correo.Enabled = trufal;
            comboBox_Idioma.Enabled = trufal;
        }

        private void Form_ABMUsuarios_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMUsuarios_FormClosing(object sender, FormClosingEventArgs e)
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
