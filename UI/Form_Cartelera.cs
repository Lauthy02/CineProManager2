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

namespace UI
{
    public partial class Form_Cartelera : Form
    {
        BLL_PELICULA bllpelicula = new BLL_PELICULA();
        BLL_CINE bllcine = new BLL_CINE();

        public BE_PELICULA PeliculaSeleccionada { get; set; }

        public Form_Cartelera()
        {
            InitializeComponent();
        }

        private void Form_Cartelera_Load(object sender, EventArgs e)
        {
            LlenarComboBoxDeCines();
            LlenarListBoxPeliculas();
        }

        private void listBox_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ComprarEntradas.Enabled = true;
            BE_PELICULA peliculaaux = new BE_PELICULA();
            peliculaaux = (BE_PELICULA)listBox_Peliculas.SelectedItem;
            label_Titulo.Text = "Titulo: " + peliculaaux.Titulo;
            label_Director.Text = "Director: " + peliculaaux.Director;
            label_Duracion.Text = "Duración: " + peliculaaux.Duracion.ToString();
            label_Genero.Text = "Género: " + peliculaaux.Genero.ToString();
            pictureBox1.Image = ConvertirBytesAImagen(peliculaaux.Imagen);
            richTextBox_Descripcion.Text = peliculaaux.Descripcion;
        }

        private void button_ComprarEntradas_Click(object sender, EventArgs e)
        {
            PeliculaSeleccionada = (BE_PELICULA)listBox_Peliculas.SelectedItem;
            Form_ComprarEntradas formdcomprarentradas = new Form_ComprarEntradas();
            formdcomprarentradas.MainForm = this;
            formdcomprarentradas.Show();
        }

        private void LlenarComboBoxDeCines()
        {
            comboBox_Cines.DataSource = null;
            comboBox_Cines.DataSource = bllcine.ListarCines();
        }

        private void LlenarListBoxPeliculas()
        {
            listBox_Peliculas.DataSource = null;
            listBox_Peliculas.DataSource = bllpelicula.ListarPeliculas();
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
    }
}
