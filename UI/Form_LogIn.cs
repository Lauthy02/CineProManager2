using BE.SESION;
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
    public partial class Form_LogIn : Form
    {
        BLL_SESION bllsesion;

        public Form_LogIn()
        {
            InitializeComponent();
            bllsesion = new BLL_SESION();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var res = bllsesion.LogIn(textBox_NombreDeUsuario.Text, textBox_Contrasenia.Text);
                Form_MDIPrincipal form_MDIPrincipal = (Form_MDIPrincipal)this.MdiParent;
                form_MDIPrincipal.ValidarForm();
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
    }
}
