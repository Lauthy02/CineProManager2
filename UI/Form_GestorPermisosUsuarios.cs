using BE;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BE.PERMISOS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form_GestorPermisosUsuarios : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_USUARIO bllusuario;
        BLL_PERMISO bllpermiso;
        BE_USUARIO usuarioseleccionado;
        BE_USUARIO usuarioaux;

        public Form_GestorPermisosUsuarios()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            bllusuario = new BLL_USUARIO();
            bllpermiso = new BLL_PERMISO();
            comboBox_Usuarios.DataSource = bllusuario.ListarUsuarios();
            comboBox_Acciones.DataSource = bllpermiso.BuscarTodasLasAcciones();
            comboBox_Roles.DataSource = bllpermiso.BuscarTodosLosRoles();
        }

        private void button_ConfigurarUsuario_Click(object sender, EventArgs e)
        {
            usuarioseleccionado = (BE_USUARIO)comboBox_Usuarios.SelectedItem;
            usuarioaux = new BE_USUARIO();
            usuarioaux.Id = usuarioseleccionado.Id;
            usuarioaux.Nombre = usuarioseleccionado.Nombre;
            usuarioaux.Apellido = usuarioseleccionado.Apellido;

            bllpermiso.LlenarUsuarioPermisos(usuarioaux);
            MostrarPermisos(usuarioaux);
        }

        private void MostrarPermisos(BE_USUARIO usuarioaux)
        {
            treeView1.Nodes.Clear();
            TreeNode tn = new TreeNode(usuarioaux.Nombre);
            foreach (var permiso in usuarioaux.ListaDePermisos)
            {
                LlenarTreeView(tn, permiso);
            }
            treeView1.Nodes.Add(tn);
            treeView1.ExpandAll();
        }

        private void LlenarTreeView(TreeNode padre, BE_PERMISO permiso)
        {
            TreeNode hijo = new TreeNode(permiso.Nombre);
            hijo.Tag = permiso;
            padre.Nodes.Add(hijo);
            foreach (var item in permiso.ListaDeHijos)
            {
                LlenarTreeView(hijo, item);
            }
        }

        private void button_AgregarAccion_Click(object sender, EventArgs e)
        {
            if (usuarioaux != null)
            {
                var accion = (BE_ACCION)comboBox_Acciones.SelectedItem;
                if (accion != null)
                {
                    var esta = false;
                    foreach (var item in usuarioaux.ListaDePermisos)
                    {
                        if (bllpermiso.ExistePermiso(item,accion.Id))
                        {
                            esta = true;
                            break;
                        }
                    }

                    if (esta)
                    {
                        MessageBox.Show("El usuario ya tiene una acción");
                    }
                    else
                    {
                        usuarioaux.ListaDePermisos.Add(accion);
                        MostrarPermisos(usuarioaux);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void button_AgregarRol_Click(object sender, EventArgs e)
        {
            
            if (usuarioaux != null)
            {
                var rol = (BE_ROL)comboBox_Roles.SelectedItem;
                if (true)
                {
                    var esta = false;
                    foreach (var item in usuarioaux.ListaDePermisos)
                    {
                        if (bllpermiso.ExistePermiso(item, rol.Id))
                        {
                            esta = true;
                            break;
                        }
                    }

                    if (esta)
                    {
                        MessageBox.Show("El usuario ya tiene un rol");
                    }
                    else
                    {
                        bllpermiso.LlenarRolPermisos(rol);

                        usuarioaux.ListaDePermisos.Add(rol);
                        MostrarPermisos(usuarioaux);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void button_GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                bllusuario.GuardarPermisos(usuarioaux);
                MessageBox.Show($"Cambios en el usuario {usuarioaux} guardados");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los cambios");
            }
        }

        private void Form_GestorPermisosUsuarios_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorPermisosUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
