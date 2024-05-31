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

namespace UI
{
    public partial class Form_Cartelera : Form
    {
        public Form_Cartelera()
        {
            InitializeComponent();
        }

        private void Form_Cartelera_Load(object sender, EventArgs e)
        {
            string rutaImagen = @"C:\Users\Lauta\Downloads\Fotos peliculas\VolverAlFuturo1.jpeg";
            Image imagen = Image.FromFile(rutaImagen);

            byte[] bytesimagen = ConvertirImagenABytes(imagen);
            button1.Image = ConvertirBytesAImagen(bytesimagen);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
