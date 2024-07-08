using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL.MULTIIDIOMA;
using BE.MULTIIDIOMA;
using BE.MULTIIDOMA;

namespace UI
{
    public partial class Form_Cartelera : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_PELICULA bllpelicula = new BLL_PELICULA();
        BLL_CINE bllcine = new BLL_CINE();

        public Form_Cartelera()
        {
            InitializeComponent();
            LlenarComboBoxDeCines();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        private void comboBox_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListBoxPeliculas();
        }

        private void listBox_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ComprarEntradas.Enabled = true;
            BE_PELICULA peliculaaux = new BE_PELICULA();
            peliculaaux = (BE_PELICULA)listBox_Peliculas.SelectedItem;
            if (peliculaaux != null)
            {
                label_Titulo.Text = "Titulo: " + peliculaaux.Titulo;
                label_Director.Text = "Director: " + peliculaaux.Director;
                label_Duracion.Text = "Duración: " + peliculaaux.Duracion.ToString();
                label_Genero.Text = "Género: " + peliculaaux.Genero.ToString();
                pictureBox1.Image = ConvertirBytesAImagen(peliculaaux.Imagen);
                richTextBox_Descripcion.Text = peliculaaux.Descripcion;
            }
        }

        private void button_ComprarEntradas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado");
        }

        private void LlenarComboBoxDeCines()
        {
            comboBox_Cines.DataSource = null;
            comboBox_Cines.DataSource = bllcine.ListarCines();
        }

        private void LlenarListBoxPeliculas()
        {
            BE_CINE cineaux = new BE_CINE();
            cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            listBox_Peliculas.DataSource = null;
            listBox_Peliculas.DataSource = cineaux.Cartelera.ListaDePeliculas;
            if (cineaux.Cartelera.ListaDePeliculas.Count == 0)
            {
                label_Titulo.Text = "Titulo:";
                label_Director.Text = "Director:";
                label_Duracion.Text = "Duración:";
                label_Genero.Text = "Género:";
                pictureBox1.Image = null;
                richTextBox_Descripcion.Text = "";
            }
        }

        private Image ConvertirBytesAImagen(byte[] Imagen)
        {
            if (Imagen == null || Imagen.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(Imagen))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
            }
        }

        private void Form_Cartelera_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);

            var fechaactual = DateTime.Now;
            dateTimePicker1.MinDate = fechaactual;
            dateTimePicker1.MaxDate = fechaactual.AddDays(3);

            List<DateTime> listadehorarios = new List<DateTime>();

            DateTime h1 = new DateTime(2024, 1, 1, 12, 10, 0);
            DateTime h2 = new DateTime(2024, 1, 1, 13, 40, 0);
            DateTime h3 = new DateTime(2024, 1, 1, 16, 0, 0);
            DateTime h4 = new DateTime(2024, 1, 1, 16, 50, 0);
            DateTime h5 = new DateTime(2024, 1, 1, 18, 20, 0);

            listadehorarios.Add(h1);
            listadehorarios.Add(h2);
            listadehorarios.Add(h3);
            listadehorarios.Add(h4);
            listadehorarios.Add(h5);

            comboBox_Horarios.DataSource = listadehorarios;
            comboBox_Horarios.DisplayMember = "TimeOfDay";
        }
        private void Form_Cartelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = "Año: " + dateTimePicker1.Value.Year.ToString();
            label4.Text = "Mes: " + dateTimePicker1.Value.Month.ToString();
            label5.Text = "Día: " + dateTimePicker1.Value.Day.ToString();
            label6.Text = "Hora: " + dateTimePicker1.Value.Hour.ToString() + ":" + dateTimePicker1.Value.Minute.ToString();
        }
    }
}
