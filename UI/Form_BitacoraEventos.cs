using BE.MULTIIDIOMA;
using BLL.MULTIIDIOMA;
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
using BE.MULTIIDOMA;
using BE;
using BE.BITACORAYCAMBIOS;
using BLL.BITACORAYCAMBIOS;

namespace UI
{
    public partial class Form_BitacoraEventos : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();

        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();

        public Form_BitacoraEventos()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllbitacoraeventos.ListarBitacoraEvento();
        }

        private void Form_BitacoraEventos_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_BitacoraEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Cerrar {this.Text}"));
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
