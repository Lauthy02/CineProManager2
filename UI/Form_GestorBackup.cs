using BLL.BITACORAYCAMBIOS;
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
using BE;
using BE.MULTIIDOMA;
using BE.MULTIIDIOMA;
using BLL.BACKUP;

namespace UI
{
    public partial class Form_GestorBackup : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        //BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();

        BLL_BACKUP bllbackup = new BLL_BACKUP();

        public Form_GestorBackup()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        private void button_CrearBackup_Click(object sender, EventArgs e)
        {
            bllbackup.CrearBackup();
            MessageBox.Show("Backup realizado en el directorio: C:\\BackupCineProManager");
        }

        private void button_RestaurarBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bllbackup.RestaurarBackup(ofd.FileName);
            }
            MessageBox.Show("Datos restaurados");
        }

        private void Form_GestorBackup_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
