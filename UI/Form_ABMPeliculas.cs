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
using static System.Net.WebRequestMethods;
using System.Drawing.Imaging;
using System.Diagnostics.Contracts;
using BE.MULTIIDOMA;
using BLL.MULTIIDIOMA;
using BE.MULTIIDIOMA;

namespace UI
{
    public partial class Form_ABMPeliculas : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_PELICULA bllpelicula = new BLL_PELICULA();
        BE_PELICULA peliculaaux;
        bool operacion = false;
        
        public Form_ABMPeliculas()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxGenero();
            LlenarDataGrid();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos");

            ControlesEn(true);

            button_Baja.Enabled = false;
            button_Modificacion.Enabled = false;
            button_Guardar.Enabled = true;

            operacion = true;
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            peliculaaux = new BE_PELICULA();

            peliculaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            peliculaaux.Titulo = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea dar de baja la película {peliculaaux.Titulo}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllpelicula.BorrarPelicula(peliculaaux);
                LlenarDataGrid();
            }
        }

        private void button_Modificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifique los datos");
            
            ControlesEn(true);

            button_Alta.Enabled = false;
            button_Baja.Enabled = false;
            button_Guardar.Enabled = true;

            textBox_Titulo.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value.ToString();
            textBox_Director.Text = dataGridView1.CurrentRow.Cells["Director"].Value.ToString();
            textBox_Duracion.Text = dataGridView1.CurrentRow.Cells["Duracion"].Value.ToString();
            comboBox_Genero.Text = dataGridView1.CurrentRow.Cells["Genero"].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (ControlesConDatos())
            {
                ControlesEn(false);

                button_Alta.Enabled = true;
                button_Baja.Enabled = true;
                button_Modificacion.Enabled = true;
                button_Guardar.Enabled = false;

                peliculaaux = new BE_PELICULA();

                peliculaaux.Titulo = textBox_Titulo.Text;
                peliculaaux.Director = textBox_Director.Text;
                peliculaaux.Duracion = int.Parse(textBox_Duracion.Text);
                peliculaaux.Genero = (BE_PELICULA_GENERO_ENUM)Enum.Parse(typeof(BE_PELICULA_GENERO_ENUM), comboBox_Genero.SelectedItem.ToString());
                peliculaaux.Descripcion = richTextBox1.Text;

                string ruta = textBox_ImagenRuta.Text;
                Image imagenoriginal = Image.FromFile(ruta);
                peliculaaux.Imagen = RedimensionarYConvertirImagen(imagenoriginal, 80, 100, ImageFormat.Jpeg);

                if (operacion)
                {
                    peliculaaux.Id = 0;
                    bllpelicula.GuardarPelicula(peliculaaux);
                    LlenarDataGrid();
                }
                else
                {
                    peliculaaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                    bllpelicula.GuardarPelicula(peliculaaux);
                    LlenarDataGrid();
                }
                textBox_Titulo.Text = "";
                textBox_Director.Text = "";
                textBox_Duracion.Text = "";
                comboBox_Genero.Text = "";
                richTextBox1.Text = "";
                textBox_ImagenRuta.Text = "";
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private bool ControlesConDatos()
        {
            if (textBox_Titulo.Text == "" || textBox_Director.Text == "" || textBox_Duracion.Text == "" || comboBox_Genero.Text == "" || richTextBox1.Text == "" || textBox_ImagenRuta.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_BuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox_ImagenRuta.Text = openFileDialog1.FileName;
        }

        private void LlenarComboBoxGenero()
        {
            var generos = Enum.GetValues(typeof(BE_PELICULA_GENERO_ENUM));
            foreach (var genero in generos)
            {
                comboBox_Genero.Items.Add(genero.ToString());
            }
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllpelicula.ListarPeliculas();
            dataGridView1.Columns["Descripcion"].Width = 200;
        }

        private void ControlesEn(bool trufal)
        {
            textBox_Titulo.Enabled = trufal;
            textBox_Director.Enabled = trufal;
            textBox_Duracion.Enabled = trufal;
            comboBox_Genero.Enabled = trufal;
            button_BuscarImagen.Enabled = trufal;
            richTextBox1.Enabled = trufal;
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
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

        public byte[] RedimensionarYConvertirImagen(Image imagenOriginal, int nuevoAncho, int nuevoAlto, ImageFormat formato)
        {
            var imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);

            using (var graphics = Graphics.FromImage(imagenRedimensionada))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.DrawImage(imagenOriginal, 0, 0, nuevoAncho, nuevoAlto);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                imagenRedimensionada.Save(ms, formato ?? ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void Form_ABMPeliculas_Load(object sender, EventArgs e)
        {
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_ABMPeliculas_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }
    }
}
