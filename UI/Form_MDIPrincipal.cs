﻿using BE;
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
    public partial class Form_MDIPrincipal : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_IDIOMA bllidioma = new BLL_IDIOMA();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();

        public Form_MDIPrincipal()
        {
            InitializeComponent();
            ValidarForm();
            MostrarIdiomas();
            //MarcarIdioma();
            //Traducir();
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

        public void ActualizarIdioma(BE_IDIOMA idioma) //Implementación de la interfaz BLL_IOBSERVERIDIOMA
        { 
            
        }

        public void MarcarIdioma()
        {
            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                foreach (var item in idiomasToolStripMenuItem.DropDownItems)
                {
                    ((ToolStripMenuItem)item).Enabled = true;
                    ((ToolStripMenuItem)item).Checked = BE_SESION.ObtenerInstancia.Usuario.Idioma.Id.Equals(((BE_IDIOMA)((ToolStripMenuItem)item).Tag).Id);
                }
            }
            else
            {
                foreach (var item in idiomasToolStripMenuItem.DropDownItems)
                {
                    var i = ((BE_IDIOMA)((ToolStripMenuItem)item).Tag);

                    ((ToolStripMenuItem)item).Checked = i.PorDefecto;
                    ((ToolStripMenuItem)item).Enabled = false;
                }
            }
        }

        private void MostrarIdiomas()
        {
            var idiomas = bllidioma.ListarIdiomas();

            foreach (var item in idiomas)
            {
                var t = new ToolStripMenuItem();
                t.Text = item.Nombre;
                t.Tag = item;
                idiomasToolStripMenuItem.DropDownItems.Add(t);

                t.Click += idioma_Click;
            }
        }

        private void idioma_Click(object sender, EventArgs e)
        {
            bllsesion.CambiarIdioma(((BE_IDIOMA)((ToolStripMenuItem)sender).Tag));
            MarcarIdioma();
        }

        private void Traducir()
        {
            BE_IDIOMA idiomaaux = new BE_IDIOMA();

            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                idiomaaux = BE_SESION.ObtenerInstancia.Usuario.Idioma;
            }

            blltraductor.CambiarIdiomaEnFormulario(this, idiomaaux);
        }

        private void Form_MDIPrincipal_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }
    }
}
