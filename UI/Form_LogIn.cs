using BE;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BE.SESION;
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
    public partial class Form_LogIn : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BE_IDIOMA idiomasinuso = new BE_IDIOMA();

        public Form_LogIn()
        {
            InitializeComponent();
            ActualizarIdioma(idiomasinuso);
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var res = bllsesion.LogIn(textBox_NombreDeUsuario.Text, textBox_Contrasenia.Text);
                Form_MDIPrincipal form_MDIPrincipal = (Form_MDIPrincipal)this.MdiParent;
                form_MDIPrincipal.ValidarForm();
                form_MDIPrincipal.MarcarIdioma();
                form_MDIPrincipal.ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
                this.Close();
            }
            catch (BE_LOGIN_EXCEPCION error)
            {
                switch (error.Resultado)
                {
                    case BE_LOGIN_RESULTADO_ENUM.NombreDeUsuarioIncorrecto:
                        MessageBox.Show("Nombre de usuario incorrecto");
                        break;
                    case BE_LOGIN_RESULTADO_ENUM.ContraseniaIncorrecta:
                        MessageBox.Show("Contraseña incorrecta");
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
