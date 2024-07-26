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
    public partial class Form_MDIPrincipal : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_IDIOMA bllidioma = new BLL_IDIOMA();
        BE_IDIOMA idiomasinuso = new BE_IDIOMA();

        public Form_MDIPrincipal()
        {
            InitializeComponent();
            ValidarForm();
            MostrarIdiomas();
            MarcarIdioma();
            ActualizarIdioma(idiomasinuso);
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

        private void gestionarCinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GestorCines formgestorcines = new Form_GestorCines();
            formgestorcines.MdiParent = this;
            formgestorcines.Show();
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

        private void aBMSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMSalas formabmsalas = new Form_ABMSalas();
            formabmsalas.MdiParent = this;
            formabmsalas.Show();
        }

        private void aBMFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMFunciones formabmfunciones = new Form_ABMFunciones();
            formabmfunciones.MdiParent = this;
            formabmfunciones.Show();
        }

        private void aBMIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMIdioma formabmidioma = new Form_ABMIdioma();
            formabmidioma.MdiParent = this;
            formabmidioma.Show();
        }

        private void reservarEntradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_EntradasReservar formcartelera = new Form_EntradasReservar();
            formcartelera.MdiParent = this;
            formcartelera.Show();
        }

        private void pagarEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EntradasPagar formentradaspagar = new Form_EntradasPagar();
            formentradaspagar.MdiParent = this;
            formentradaspagar.Show();
        }

        private void emitirEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EntradasEmitir formentradasemitir = new Form_EntradasEmitir();
            formentradasemitir.MdiParent = this;
            formentradasemitir.Show();
        }

        private void marcarEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EntradasMarcar formentradasmarcar = new Form_EntradasMarcar();
            formentradasmarcar.MdiParent = this;
            formentradasmarcar.Show();
        }

        public void ValidarForm() //Para los permisos
        {
            MenuItemsEnDisabled(gestoresToolStripMenuItem);
            MenuItemsEnDisabled(cineToolStripMenuItem);

            iniciarSesionToolStripMenuItem.Enabled = !BE_SESION.ObtenerInstancia.Logueado();
            cerrarSesionToolStripMenuItem.Enabled = BE_SESION.ObtenerInstancia.Logueado();

            if (BE_SESION.ObtenerInstancia.Logueado())
            {
                toolStripStatusLabel_Sesion.Text = "Sesión iniciada";
                toolStripStatusLabel_Sesion.ForeColor = Color.Green;
                toolStripStatusLabel_NomApe.Text = BE_SESION.ObtenerInstancia.Usuario.ToString();
                toolStripStatusLabel_Correo.Text = BE_SESION.ObtenerInstancia.Usuario.Correo;
                toolStripStatusLabel_Rol.Text = BE_SESION.ObtenerInstancia.Usuario.ListaDePermisos[0].Nombre;

                ValidarMenuPorItem(gestoresToolStripMenuItem);
                ValidarMenuPorItem(cineToolStripMenuItem);
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

        public void ValidarMenuPorItem(ToolStripMenuItem menuitem)
        {
            foreach (ToolStripDropDownItem menudownitem in menuitem.DropDownItems)
            {
                foreach (var permiso in BE_SESION.ObtenerInstancia.Usuario.ListaDePermisos)
                {
                    menudownitem.Enabled = BE_SESION.ObtenerInstancia.EstaEnElRol((BE_PERMISO_TIPO_ENUM)Enum.Parse(typeof(BE_PERMISO_TIPO_ENUM), menudownitem.Tag.ToString()));
                }
            }
        }

        public void MenuItemsEnDisabled(ToolStripMenuItem menuitem)
        {
            foreach (ToolStripDropDownItem menudownitem in menuitem.DropDownItems)
            {
                menudownitem.Enabled = false;
            }
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

            foreach (var idioma in idiomas)
            {
                var t = new ToolStripMenuItem();
                t.Text = idioma.Nombre;
                t.Tag = idioma;
                if (!idioma.ListoParaUsar)
                {
                    t.ForeColor = Color.Red;
                }
                idiomasToolStripMenuItem.DropDownItems.Add(t);

                t.Click += idioma_Click;
            }
        }

        private void idioma_Click(object sender, EventArgs e)
        {
            bllsesion.CambiarIdioma(((BE_IDIOMA)((ToolStripMenuItem)sender).Tag));
            MarcarIdioma();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        private void Form_MDIPrincipal_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma) //Implementación de la interfaz BE_IOBSERVERIDIOMA
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
