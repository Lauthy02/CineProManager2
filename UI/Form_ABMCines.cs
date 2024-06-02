﻿using BE;
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

namespace UI
{
    public partial class Form_ABMCines : Form
    {
        BLL_CINE bllcine = new BLL_CINE();
        BE_CINE cineaux;
        bool operacion = false;

        public Form_ABMCines()
        {
            InitializeComponent();
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
            cineaux = new BE_CINE();

            cineaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            cineaux.Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea dar de baja el cine {cineaux.Nombre}?", "Conifrmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllcine.BorrarCine(cineaux);
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

            textBox_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox_Zona.Text = dataGridView1.CurrentRow.Cells["Zona"].Value.ToString();
            textBox_Direccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();

            operacion = false;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ControlesEn(false);

            button_Alta.Enabled = true;
            button_Baja.Enabled = true;
            button_Modificacion.Enabled = true;
            button_Guardar.Enabled = false;

            cineaux = new BE_CINE();

            cineaux.Nombre = textBox_Nombre.Text;
            cineaux.Zona = textBox_Zona.Text;
            cineaux.Direccion = textBox_Direccion.Text;

            if (operacion)
            {
                cineaux.Id = 0;
                bllcine.GuardarCine(cineaux);
                LlenarDataGrid();
            }
            else
            {
                cineaux.Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                bllcine.GuardarCine(cineaux);
                LlenarDataGrid();
            }

            textBox_Nombre.Text = "";
            textBox_Zona.Text = "";
            textBox_Direccion.Text = "";
        }

        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllcine.ListarCines();
        }

        private void ControlesEn(bool trufal)
        {
            textBox_Nombre.Enabled = trufal;
            textBox_Zona.Enabled = trufal;
            textBox_Direccion.Enabled = trufal;
        }
    }
}
