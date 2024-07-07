using BE.PERMISOS;
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
using BLL.MULTIIDIOMA;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;

namespace UI
{
    public partial class Form_GestorPermisos : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_PERMISO bllpermiso;
        BE_ROL rolseleccionado;

        public Form_GestorPermisos()
        {
            InitializeComponent();
            bllpermiso = new BLL_PERMISO();
            LlenarComboBoxAccionesYRoles();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        #region Botones
        private void button_AgregarAccion_Click(object sender, EventArgs e)
        {
            if (rolseleccionado != null)
            {
                var accionaux = (BE_ACCION)comboBox_Acciones.SelectedItem;
                if (accionaux != null)
                {
                    var esta = bllpermiso.ExistePermiso(rolseleccionado, accionaux.Id);
                    if (esta)
                    {
                        MessageBox.Show("Ya existe la acción");
                    }
                    else
                    {
                        rolseleccionado.AgregarHijo(accionaux);
                        MessageBox.Show("Accion agregada");
                        MostrarRol(false);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una accion para agregarla");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol para agregar una acción");
            }
        }

        private void button_GuardarNuevaAccion_Click(object sender, EventArgs e)
        {
            BE_ACCION accionaux = new BE_ACCION();
            accionaux.Nombre = textBox_NombreNuevaAccion.Text;

            bllpermiso.GuardarPermiso(accionaux,false);
            LlenarComboBoxAccionesYRoles();

            MessageBox.Show("Accion guardada correctamente");
            textBox_NombreNuevaAccion.Text = "";
        }

        private void button_AgregarRol_Click(object sender, EventArgs e)
        {
            if (rolseleccionado != null)
            {
                var rol = (BE_ROL)comboBox_Roles.SelectedItem;
                if (rol != null)
                {
                    var esta = bllpermiso.ExistePermiso(rolseleccionado, rol.Id);
                    if (esta)
                    {
                        MessageBox.Show("Ya existe el rol");
                    }
                    else
                    {
                        bllpermiso.LlenarRolPermisos(rol);
                        rolseleccionado.AgregarHijo(rol);
                        MessageBox.Show("Rol agregado");
                        MostrarRol(false);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol para agregarlo");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }   
        }

        private void button_ConfigurarRol_Click(object sender, EventArgs e)
        {
            var aux = (BE_ROL)comboBox_Roles.SelectedItem;
            rolseleccionado = new BE_ROL();
            rolseleccionado.Id = aux.Id;
            rolseleccionado.Nombre = aux.Nombre;

            MostrarRol(true);
        }

        private void button_GuardarNuevoRol_Click(object sender, EventArgs e)
        {
            BE_ROL rolaux = new BE_ROL();
            rolaux.Nombre = textBox_NombreNuevoRol.Text;

            bllpermiso.GuardarPermiso(rolaux, true);
            LlenarComboBoxAccionesYRoles();

            MessageBox.Show("Rol Guardado correctamente");
            textBox_NombreNuevoRol.Text = "";
        }

        private void button_GuardarRol_Click(object sender, EventArgs e)
        {
            try
            {
                bllpermiso.GuardarRol(rolseleccionado);
                MessageBox.Show("Rol guardado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el rol");
            }
        }
        #endregion

        #region Funciones
        private void LlenarComboBoxAccionesYRoles()
        {
            comboBox_Acciones.DataSource = bllpermiso.BuscarTodasLasAcciones();
            comboBox_Roles.DataSource = bllpermiso.BuscarTodosLosRoles();
        }

        void MostrarRol(bool init)
        {
            if (rolseleccionado == null) return;
            IList<BE_PERMISO> rol = null;
            if (init)
            {
                //Traigo a los hijos de la base
                rol = bllpermiso.BuscarTodo(rolseleccionado.Id.ToString());
                foreach (var item in rol)
                {
                    rolseleccionado.AgregarHijo(item);
                }
            }
            else
            {
                rol = rolseleccionado.ListaDeHijos;
            }

            treeView1.Nodes.Clear();

            TreeNode raiz = new TreeNode(rolseleccionado.Nombre);
            raiz.Tag = rolseleccionado;
            treeView1.Nodes.Add(raiz);
            foreach (var hijo in rol)
            {
                MostrarEnTreeView(raiz, hijo);
            }
            treeView1.ExpandAll();
        }

        private void MostrarEnTreeView(TreeNode raiz, BE_PERMISO hijo)
        {
            TreeNode nodoaux = new TreeNode(hijo.Nombre);
            raiz.Tag = hijo;
            raiz.Nodes.Add(nodoaux);
            if (hijo.ListaDeHijos != null)
            {
                foreach (var item in hijo.ListaDeHijos)
                {
                    MostrarEnTreeView(nodoaux, item);
                }
            }
        }
        #endregion

        private void Form_GestorPermisos_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
