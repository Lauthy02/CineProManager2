using BE;
using BE.BITACORAYCAMBIOS;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;
using BE.SESION;
using BLL;
using BLL.BITACORAYCAMBIOS;
using BLL.DIGITOVERIFICADOR;
using BLL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_DIGITOVERIFICADOR blldigitoverificador = new BLL_DIGITOVERIFICADOR();

        BE_IDIOMA idiomasinuso = new BE_IDIOMA();
        bool flagDV;

        public Form_LogIn(bool flagdv)
        {
            InitializeComponent();
            ActualizarIdioma(idiomasinuso);
            flagDV = flagdv;
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagDV)
                {
                    //Todo normal
                    var res = bllsesion.LogIn(textBox_NombreDeUsuario.Text, textBox_Contrasenia.Text);
                    Form_MDIPrincipal form_MDIPrincipal = (Form_MDIPrincipal)this.MdiParent;
                    form_MDIPrincipal.ValidarForm();
                    form_MDIPrincipal.MarcarIdioma();
                    form_MDIPrincipal.ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
                    bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, "LogIn"));
                    this.Close();
                }
                else 
                {
                    var res = bllsesion.LogIn(textBox_NombreDeUsuario.Text, textBox_Contrasenia.Text);
                    if (BE_SESION.ObtenerInstancia.EstaEnElRol((BE_PERMISO_TIPO_ENUM)Enum.Parse(typeof(BE_PERMISO_TIPO_ENUM), "GestionarBackup")))
                    {
                        Form_MDIPrincipal form_MDIPrincipal = (Form_MDIPrincipal)this.MdiParent;
                        form_MDIPrincipal.ValidarForm();
                        form_MDIPrincipal.MarcarIdioma();
                        form_MDIPrincipal.ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
                        bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, "LogIn"));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No tiene permisos para ingresar al sistema");
                        bllsesion.LogOut();
                        this.Close();
                    }
                }
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
