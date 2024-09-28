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
using BLL.BITACORAYCAMBIOS;
using BE.BITACORAYCAMBIOS;
using BLL.DIGITOVERIFICADOR;

namespace UI
{
    public partial class Form_EntradasReservar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_PELICULA bllpelicula = new BLL_PELICULA();
        BLL_CINE bllcine = new BLL_CINE();
        BLL_ENTRADA bllentrada = new BLL_ENTRADA();
        BLL_DIGITOVERIFICADOR blldigitoverificador = new BLL_DIGITOVERIFICADOR();
        BLL_BITACORA_CAMBIOS_ENTRADA bllbitacoracambiosentrada = new BLL_BITACORA_CAMBIOS_ENTRADA();

        public Form_EntradasReservar()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarComboBoxDeCines();
        }

        private void comboBox_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboBoxDeSalas();
            BE_CINE cineaux = new BE_CINE();
            cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            if (cineaux != null)
            {
                label_Cine.Text = "Cine: " + cineaux.ToString();
                label_CineDireccion.Text = "Dirección: " + cineaux.Direccion;
            }
        }

        private void comboBox_Salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListBoxFunciones();
            BE_SALA salaaux = new BE_SALA();
            salaaux = (BE_SALA)comboBox_Salas.SelectedItem;
            if (salaaux != null)
            {
                label_NumeroDeSala.Text = "Número de sala: " + salaaux.NumeroDeSala.ToString();
                label_Precio.Text = "Precio: " + salaaux.Precio.ToString();
            }
        }

        private void listBox_Funciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE_FUNCION funcionaux = new BE_FUNCION();
            funcionaux = (BE_FUNCION)listBox_Funciones.SelectedItem;
            if (funcionaux != null)
            {
                label_Titulo.Text = "Titulo: " + funcionaux.Pelicula.Titulo;
                label_Director.Text = "Director: " + funcionaux.Pelicula.Director;
                label_Duracion.Text = "Duración: " + funcionaux.Pelicula.Duracion.ToString();
                label_Genero.Text = "Género: " + funcionaux.Pelicula.Genero.ToString();
                pictureBox1.Image = ConvertirBytesAImagen(funcionaux.Pelicula.Imagen);
                richTextBox_Descripcion.Text = funcionaux.Pelicula.Descripcion;


                label_NumeroDeFuncion.Text = "Número de función: " + funcionaux.Id.ToString();
                label_Película.Text = "Película: " + funcionaux.Pelicula.Titulo;
                label_Anio.Text = "Año: " + funcionaux.Horario.Year.ToString();
                label_Mes.Text = "Mes: " + funcionaux.Horario.Month.ToString();
                label_Dia.Text = "Día: " + funcionaux.Horario.Day.ToString();
                label_Hora.Text = "Hora: " + funcionaux.Horario.Hour.ToString() + ":" + funcionaux.Horario.Minute.ToString();

                BE_SALA salaaux = new BE_SALA();
                salaaux = (BE_SALA)comboBox_Salas.SelectedItem;
                if (salaaux != null)
                {
                    CrearDataGridViewPersonalizado(salaaux.Capacidad);
                }
            }
        }

        private void button_ReservarEntradas_Click(object sender, EventArgs e)
        {
            BE_ENTRADA entradaaux = new BE_ENTRADA();
            BE_BITACORA_CAMBIOS_ENTRADA bitacoracambiosentradaaux = new BE_BITACORA_CAMBIOS_ENTRADA();
            BE_BUTACA butacaaux = new BE_BUTACA();
            BE_SALA salauax = new BE_SALA();

            salauax = (BE_SALA)comboBox_Salas.SelectedItem;

            string fila = (string)dataGridView_Butacas.Rows[dataGridView_Butacas.SelectedCells[0].RowIndex].Cells[0].Value;
            butacaaux.Fila = (BE_BUTACA_FILA_ENUM)Enum.Parse(typeof(BE_BUTACA_FILA_ENUM), fila);
            butacaaux.Columna = dataGridView_Butacas.SelectedCells[0].ColumnIndex;

            entradaaux.Id = 0;
            entradaaux.Cliente = BE_SESION.ObtenerInstancia.Usuario;
            entradaaux.Funcion = (BE_FUNCION)listBox_Funciones.SelectedItem;
            entradaaux.AsientoReservado = butacaaux; 
            entradaaux.FechaDeReserva = DateTime.Now;
            entradaaux.Estado = BE_ENTRADA_ESTADO_ENUM.Reservada;
            entradaaux.Sala = salauax;
            entradaaux.Precio = salauax.Precio;
            entradaaux.DigitoVerificador = blldigitoverificador.CalcularDVH(entradaaux);

            bllentrada.GuardarEntrada(entradaaux);

            bitacoracambiosentradaaux.UsuarioQueModifica = BE_SESION.ObtenerInstancia.Usuario;
            bitacoracambiosentradaaux.FechaDeCambio = DateTime.Now;
            bitacoracambiosentradaaux.Activo = true;
            bitacoracambiosentradaaux.B_Entrada = entradaaux;

            bllbitacoracambiosentrada.GuardarEntrada(bitacoracambiosentradaaux);

            MessageBox.Show("Entrada reservada correctamente");
            MessageBox.Show("Hable con el taquillero para pagar la entrada");

            VaciarTodosLosControles();
            button_ReservarEntradas.Enabled = false;
        }

        private void VaciarTodosLosControles()
        {
            label_Titulo.Text = "Titulo:";
            label_Director.Text = "Director:";
            label_Duracion.Text = "Duración:";
            label_Genero.Text = "Género:";
            pictureBox1.Image = null;
            richTextBox_Descripcion.Text = "";

            label_NumeroDeFuncion.Text = "Número de función: ";
            label_Película.Text = "Película: ";
            label_Anio.Text = "Año: ";
            label_Mes.Text = "Mes: ";
            label_Dia.Text = "Día: ";
            label_Hora.Text = "Hora: ";
        }

        private void LlenarComboBoxDeCines()
        {
            comboBox_Cines.DataSource = null;
            comboBox_Cines.DataSource = bllcine.ListarCines();
        }

        private void LlenarComboBoxDeSalas()
        {
            BE_CINE cineaux = new BE_CINE();
            cineaux = (BE_CINE)comboBox_Cines.SelectedItem;
            comboBox_Salas.DataSource = null;
            comboBox_Salas.DataSource = cineaux.ListaDeSalas;
            //comboBox_Salas.DisplayMember = "NumeroDeSala";
        }

        private void LlenarListBoxFunciones()
        {
            BE_SALA salaaux = new BE_SALA();
            salaaux = (BE_SALA)comboBox_Salas.SelectedItem;
            if (salaaux != null)
            {
                listBox_Funciones.DataSource = null;
                listBox_Funciones.DataSource = salaaux.ListaDeFunciones;
                if (salaaux.ListaDeFunciones.Count == 0)
                {
                    label_Titulo.Text = "Titulo:";
                    label_Director.Text = "Director:";
                    label_Duracion.Text = "Duración:";
                    label_Genero.Text = "Género:";
                    pictureBox1.Image = null;
                    richTextBox_Descripcion.Text = "";
                }
            }
        }

        private void CrearDataGridViewPersonalizado(int capacidad)
        {
            dataGridView_Butacas.Rows.Clear();
            dataGridView_Butacas.Columns.Clear();

            int cantidadColumnas = capacidad / 2;
            int cantidadFilas = capacidad - cantidadColumnas;

            // Configurar columnas
            dataGridView_Butacas.Columns.Add("Filas", "Filas");
            for (int i = 0; i < cantidadColumnas; i++)
            {
                dataGridView_Butacas.Columns.Add($"Column{i + 1}", $"Column {i + 1}");
                dataGridView_Butacas.Columns[i + 1].Width = 50;
            }

            // Agregar filas
            for (int i = 0; i < cantidadFilas; i++)
            {
                dataGridView_Butacas.Rows.Add($"{(BE_BUTACA_FILA_ENUM)Enum.Parse(typeof(BE_BUTACA_FILA_ENUM), i.ToString())}");
            }

            MarcarButacasOcupadas(dataGridView_Butacas);
        }

        private void MarcarButacasOcupadas(DataGridView datagrid)
        {
            BE_FUNCION funcionaux = new BE_FUNCION();
            funcionaux = (BE_FUNCION)listBox_Funciones.SelectedItem;
            if (funcionaux != null)
            {
                if (funcionaux.ListaDeAsientosOcupados.Count != 0)
                {
                    foreach (var butaca in funcionaux.ListaDeAsientosOcupados)
                    {
                        datagrid.Rows[Convert.ToInt32(butaca.Fila)].Cells[butaca.Columna].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridView_Butacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Butacas.SelectedCells[0].ColumnIndex != 0)
            {
                dataGridView_Butacas.SelectedCells[0].Style.BackColor = Color.Red;
                label_Butaca.Text = $"Butaca: Fila: {dataGridView_Butacas.Rows[dataGridView_Butacas.SelectedCells[0].RowIndex].Cells[0].Value} - Columna: {dataGridView_Butacas.SelectedCells[0].ColumnIndex}";
            }
            else
            {
                MessageBox.Show("No se puede seleccionar en esta columna");
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
        }

        private void Form_Cartelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            bllsesion.QuitarObservadorForm(this);
        }

        public void ActualizarIdioma(BE_IDIOMA idioma)
        {
            blltraductor.CambiarIdiomaEnFormulario(this, idioma);
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);
            MessageBox.Show("Ya puede reservar las entradas");
            button_ReservarEntradas.Enabled = true;
        }

        private void ControlesEn(bool trufal)
        {
            comboBox_Cines.Enabled = trufal;
            comboBox_Salas.Enabled = trufal;
            groupBox_Funciones.Enabled = trufal;
            groupBox_DetalleEntrada.Enabled = trufal;
            groupBox_Butacas.Enabled = trufal;
        }
    }
}
