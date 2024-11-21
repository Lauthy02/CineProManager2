using BE.BITACORAYCAMBIOS;
using BE;
using BE.MULTIIDIOMA;
using BLL.BITACORAYCAMBIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE.MULTIIDOMA;
using BLL.MULTIIDIOMA;

namespace UI
{
    public partial class Form_GestorSerializar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();

        BLL_CONFIGURACION bllconfiguracion = new BLL_CONFIGURACION();

        public Form_GestorSerializar()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        private void button_Deserializar_Click(object sender, EventArgs e)
        {
            List<BE_CONFIGURACION> aux = new List<BE_CONFIGURACION>();
            aux.Add(bllconfiguracion.CargarConfiguracion());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux;
        }

        private void Form_GestorSerializar_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorSerializar_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Cerrar {this.Text}"));
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma) //Implementación de la interfaz BE_IOBSERVERIDIOMA
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
