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
    public partial class Form_MDIPrincipal : Form
    {
        BLL_SESION bllsesion;

        public Form_MDIPrincipal()
        {
            InitializeComponent();
            bllsesion = new BLL_SESION();
            ValidarForm();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LogIn formlogin = new Form_LogIn();
            formlogin.MdiParent = this;
            formlogin.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllsesion.LogOut();
                ValidarForm();
            }
        }

        public void ValidarForm()
        {
            iniciarSesionToolStripMenuItem.Enabled = !BE_SESION.ObtenerInstancia.Logueado();
            cerrarSesionToolStripMenuItem.Enabled = BE_SESION.ObtenerInstancia.Logueado();

            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                toolStripStatusLabel_Sesion.Text = "Sesión iniciada";
                toolStripStatusLabel_Sesion.ForeColor = Color.Green;
                toolStripStatusLabel_NomApe.Text = BE_SESION.ObtenerInstancia.Usuario.ToString();
                toolStripStatusLabel_Correo.Text = BE_SESION.ObtenerInstancia.Usuario.Correo;
                toolStripStatusLabel_Rol.Text = "Rol";
            }
            else
            {
                toolStripStatusLabel_Sesion.Text = "Sesión no iniciada";
                toolStripStatusLabel_Sesion.ForeColor = Color.Red;
                toolStripStatusLabel_NomApe.Text = "";
                toolStripStatusLabel_Correo.Text = "";
                toolStripStatusLabel_Rol.Text = "";
            }
        }
    }
}
