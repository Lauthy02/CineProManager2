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
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form_GestorReportes : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();

        BLL_CINE bllcine = new BLL_CINE();
        BLL_SALA bllsala = new BLL_SALA();
        BLL_PELICULA bllpelicula = new BLL_PELICULA();

        BLL_REPORTE bllreporte = new BLL_REPORTE();

        public Form_GestorReportes()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxCine();
            //LlenarComboBoxProducto();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            BE_CINE cineaux = (BE_CINE)comboBox_Cine.SelectedItem;
            if (checkBox_EspFecha.Checked)
            {
                //ventas totales de todos los cines con fechas
                MessageBox.Show("no implementado");
            }
            else if (checkBox_EspCine.Checked)
            {
                //Ventas totales de un cine
                dataGridView1.DataSource = bllreporte.GenerarReporteCine(cineaux);
            }
            else if (checkBox_EspCine.Checked && checkBox_EspFecha.Checked)
            {
                //Ventas totales de una cine con fechas
                MessageBox.Show("no implementado");
            }
            else
            {
                //ventas totales de todos los cines sin fechas
                MessageBox.Show("no implementado");
            }      
        }

        private void button_CrearReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("dd_MM_yyyy_HH-mm"));

            string PaginaHTML_Texto = Properties.Resources.PlantillaHTML.ToString();
            string nombredelreporte = "";
            string descripcion = ObtenerDescripcion();

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
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", descripcion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@OBSERVACIONES", "Esto es una observación");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAINICIO", monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAFIN", monthCalendar1.SelectionRange.End.ToString("dd/MM/yyyy"));

            if (dataGridView1.Rows.Count != 0)
            {
                string filas = string.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["IdCine"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NombreCine"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CantidadEntradasVendidas"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

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

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe generar algo para mostrar");
            }
        }

        private string ObtenerDescripcion()
        {
            if (checkBox_EspFecha.Checked)
            {
                //Ventas totales de todos los cines con fechas
                return "Ventas totales de todos los cines con fechas";
            }
            else if (checkBox_EspCine.Checked)
            {
                //Ventas totales de un cine
                return "Ventas totales de un cine";
            }
            else if (checkBox_EspCine.Checked && checkBox_EspFecha.Checked)
            {
                //Ventas totales de una cine con fechas
                return "Ventas totales de una cine con fechas";
            }
            else
            {
                //Ventas totales de todos los cines sin fechas
                return "Ventas totales de todos los cines sin fechas";
            }
        }

        private void LlenarComboBoxCine()
        {
            comboBox_Cine.DataSource = null;
            comboBox_Cine.DataSource = bllcine.ListarCines();
        }

        private void comboBox_Cine_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_CINE cineaux = (BE_CINE)comboBox_Cine.SelectedItem;
            if (cineaux != null)
            {
                comboBox_Sala.DataSource = null;
                comboBox_Sala.DataSource = cineaux.ListaDeSalas;
            }
        }

        private void comboBox_Sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_SALA salaaux = (BE_SALA)comboBox_Sala.SelectedItem;
            if (salaaux != null)
            {
                comboBox_Pelicula.DataSource = null;
                comboBox_Pelicula.DataSource = salaaux.ListaDeFunciones;
            }
        }

        private void checkBox_EspFecha_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = checkBox_EspFecha.Checked;
        }

        private void checkBox_EspCine_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Cine.Enabled = checkBox_EspCine.Checked;
        }

        private void checkBox_EspSala_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Sala.Enabled = checkBox_EspSala.Checked;
        }

        private void checkBox_EspPelicula_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Pelicula.Enabled = checkBox_EspPelicula.Checked;
        }

        private void checkBox_EspProducto_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Producto.Enabled = checkBox_EspProducto.Checked;
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
