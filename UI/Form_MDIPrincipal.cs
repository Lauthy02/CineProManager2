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
        BLL_SESION bllsesion = new BLL_SESION();

        public Form_MDIPrincipal()
        {
            InitializeComponent();
            //ValidarForm();
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

        private void permisosDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GestorPermisosUsuarios formgestorpermisosusuarios = new Form_GestorPermisosUsuarios();
            formgestorpermisosusuarios.MdiParent = this;
            formgestorpermisosusuarios.Show();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GestorPermisos formgestorpermisos = new Form_GestorPermisos();
            formgestorpermisos.MdiParent = this;
            formgestorpermisos.Show();
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMUsuarios formabmusuarios = new Form_ABMUsuarios();
            formabmusuarios.MdiParent = this;
            formabmusuarios.Show();
        }

        private void aBMPelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMPeliculas formabmpeliculas = new Form_ABMPeliculas();
            formabmpeliculas.MdiParent = this;
            formabmpeliculas.Show();
        }

        private void aBMCinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMCines formabmcines = new Form_ABMCines();
            formabmcines.MdiParent = this;
            formabmcines.Show();
        }

        private void carteleraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Cartelera formcartelera = new Form_Cartelera();
            formcartelera.MdiParent = this;
            formcartelera.Show();
        }

        public void ValidarForm()
        {
            gestoresToolStripMenuItem.Enabled = false;
            iniciarSesionToolStripMenuItem.Enabled = !BE_SESION.ObtenerInstancia.Logueado();
            cerrarSesionToolStripMenuItem.Enabled = BE_SESION.ObtenerInstancia.Logueado();

            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                toolStripStatusLabel_Sesion.Text = "Sesión iniciada";
                toolStripStatusLabel_Sesion.ForeColor = Color.Green;
                toolStripStatusLabel_NomApe.Text = BE_SESION.ObtenerInstancia.Usuario.ToString();
                toolStripStatusLabel_Correo.Text = BE_SESION.ObtenerInstancia.Usuario.Correo;
                toolStripStatusLabel_Rol.Text = BE_SESION.ObtenerInstancia.Usuario.ListaDePermisos[0].Nombre;

                gestoresToolStripMenuItem.Enabled = BE_SESION.ObtenerInstancia.EstaEnElRol(BE_PERMISO_TIPO_ENUM.GestionarPermisosUsuarios) && BE_SESION.ObtenerInstancia.EstaEnElRol(BE_PERMISO_TIPO_ENUM.GestionarPermisos);
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
