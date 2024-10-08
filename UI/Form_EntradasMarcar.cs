﻿using BE;
using BE.MULTIIDOMA;
using BE.MULTIIDIOMA;
using BLL;
using BLL.MULTIIDIOMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.BITACORAYCAMBIOS;
using BLL.BITACORAYCAMBIOS;
using BLL.DIGITOVERIFICADOR;

namespace UI
{
    public partial class Form_EntradasMarcar : Form, BE_IOBSERVERIDIOMA
    {
        BLL_SESION bllsesion = new BLL_SESION();
        BLL_TRADUCTOR blltraductor = new BLL_TRADUCTOR();
        BLL_ENTRADA bllentdada = new BLL_ENTRADA();
        BLL_DIGITOVERIFICADOR blldigitoverificador = new BLL_DIGITOVERIFICADOR();
        BLL_BITACORA_EVENTOS bllbitacoraeventos = new BLL_BITACORA_EVENTOS();
        BLL_BITACORA_CAMBIOS_ENTRADA bllbitacoracambiosentrada = new BLL_BITACORA_CAMBIOS_ENTRADA();

        public Form_EntradasMarcar()
        {
            InitializeComponent();
            ActualizarIdioma(BE_SESION.ObtenerInstancia.Usuario.Idioma);
            LlenarDataGrid();
        }

        private void button_UtilizarEntrada_Click(object sender, EventArgs e)
        {
            BE_ENTRADA entradaaux = new BE_ENTRADA();
            BE_BITACORA_CAMBIOS_ENTRADA bitacoracambiosentradaaux = new BE_BITACORA_CAMBIOS_ENTRADA();

            entradaaux = (BE_ENTRADA)dataGridView1.CurrentRow.DataBoundItem;
            if (entradaaux != null)
            {
                entradaaux.Estado = BE_ENTRADA_ESTADO_ENUM.Utilizada;
                entradaaux.DigitoVerificador = blldigitoverificador.CalcularDVH(entradaaux);

                bllentdada.GuardarEntrada(entradaaux);

                bitacoracambiosentradaaux.UsuarioQueModifica = BE_SESION.ObtenerInstancia.Usuario;
                bitacoracambiosentradaaux.FechaDeCambio = DateTime.Now;
                bitacoracambiosentradaaux.Activo = true;
                bitacoracambiosentradaaux.B_Entrada = entradaaux;

                bllbitacoracambiosentrada.GuardarEntrada(bitacoracambiosentradaaux);

                MessageBox.Show("Entrada utilizada correctamente");
                LlenarDataGrid();
            }
        }

        private void button_VencerEntradas_Click(object sender, EventArgs e)
        {
            BE_ENTRADA entradaaux = new BE_ENTRADA();
            entradaaux = (BE_ENTRADA)dataGridView1.CurrentRow.DataBoundItem;
            if (entradaaux != null)
            {
                entradaaux.Estado = BE_ENTRADA_ESTADO_ENUM.Vencida;

                bllentdada.GuardarEntrada(entradaaux);
                MessageBox.Show("Entrada vencida correctamente");
                LlenarDataGrid();
            }
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllentdada.BuscarEntradaPorEstado(BE_ENTRADA_ESTADO_ENUM.Emitida.ToString());
        }

        private void Form_EntradasMarcar_Load(object sender, EventArgs e)
        {
            bllbitacoraeventos.GuardarBitacoraEvento(new BE_BITACORA_EVENTOS(BE_SESION.ObtenerInstancia.Usuario, DateTime.Now, $"Abrir {this.Text}"));
            bllsesion.AgregarObservadorForm(this);
        }

        private void Form_EntradasMarcar_FormClosing(object sender, FormClosingEventArgs e)
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
