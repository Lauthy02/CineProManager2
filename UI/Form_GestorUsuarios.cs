using BE;
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

namespace UI
{
    public partial class Form_GestorUsuarios : Form
    {
        BLL_USUARIO bllusuario = new BLL_USUARIO();
        BE_USUARIO usuarioaux;
        bool operacion = false;

        public Form_GestorUsuarios()
        {
            InitializeComponent();
            LlenarDataGrid();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos");

            textBox_NombreDeUsuario.Enabled = true;
            textBox_Nombre.Enabled = true;
            textBox_Apellido.Enabled = true;
            textBox_Contrasenia.Enabled = true;
            textBox_Correo.Enabled = true;

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

            textBox_NombreDeUsuario.Enabled = true;
            textBox_Nombre.Enabled = true;
            textBox_Apellido.Enabled = true;
            textBox_Contrasenia.Enabled = true;
            textBox_Correo.Enabled = true;

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
            textBox_NombreDeUsuario.Enabled = false;
            textBox_Nombre.Enabled = false;
            textBox_Apellido.Enabled = false;
            textBox_Contrasenia.Enabled = false;
            textBox_Correo.Enabled = false;

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
    }
}
