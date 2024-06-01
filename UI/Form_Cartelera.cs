using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using System.IO;
using BLL;
using BE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form_Cartelera : Form
    {
        BLL_PELICULA bllpelicula = new BLL_PELICULA();

        public Form_Cartelera()
        {
            InitializeComponent();
        }

        private void Form_Cartelera_Load(object sender, EventArgs e)
        {
            /*
            string rutaImagen = @"C:\Users\Lauta\Downloads\Fotos peliculas\VolverAlFuturo1.jpeg";
            Image imagen = Image.FromFile(rutaImagen);

            byte[] bytesimagen = ConvertirImagenABytes(imagen);
            button1.Image = ConvertirBytesAImagen(bytesimagen);
            */
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
                imagen.Save(ms, imagen.RawFormat); // Guardar la imagen en el MemoryStream en su formato original
                return ms.ToArray(); // Convertir el MemoryStream en un arreglo de bytes
            }
        }

        private void listBox_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            BE_PELICULA peliculaaux = new BE_PELICULA();
            peliculaaux = (BE_PELICULA)listBox_Peliculas.SelectedItem;
            textBox1.Text = peliculaaux.Titulo;
            textBox2.Text = peliculaaux.Director;
            textBox3.Text = peliculaaux.Duracion.ToString();
            textBox4.Text = peliculaaux.Genero.ToString();
            pictureBox1.Image = ConvertirBytesAImagen(peliculaaux.Imagen);
            */
        }

        private void LlenarListBoxPeliculas()
        {
            listBox_Peliculas.DataSource = null;
            listBox_Peliculas.DataSource = bllpelicula.ListarPeliculas();
        }
    }
}
