using BLL.BITACORAYCAMBIOS;
using BLL.MULTIIDIOMA;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BE.BITACORAYCAMBIOS;
using BE.MULTIIDOMA;
using BE.MULTIIDIOMA;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace UI
{
    public partial class Form_GestorReportes : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();

        public Form_GestorReportes()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
        }

        private void button_CrearReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("dd_MM_yyyy_HH-mm"));

            string PaginaHTML_Texto = Properties.Resources.PlantillaHTML.ToString();
            string nombredelreporte = "";

            if (checkBox1.Checked)
            {
                nombredelreporte = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                nombredelreporte = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                nombredelreporte = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                nombredelreporte = checkBox4.Text;
            }
            else if (checkBox5.Checked)
            {
                nombredelreporte = checkBox5.Text;
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de reporte");
            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBREDELREPORTE", nombredelreporte);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", BE_SESION.ObtenerInstancia.Usuario.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESRIPCION", "Esto es una descripción");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@OBSERVACIONES", "Esto es una observación");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAINICIO", monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAFIN", monthCalendar1.SelectionRange.End.ToString("dd/MM/yyyy"));

            /*
            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            */
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    /*
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    
                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    */

                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void Form_GestorReportes_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_GestorReportes_FormClosing(object sender, FormClosingEventArgs e)
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
