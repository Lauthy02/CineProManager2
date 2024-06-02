using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_ComprarEntradas : Form
    {
        public Form_Cartelera MainForm { get; set; }

        public Form_ComprarEntradas()
        {
            InitializeComponent();
        }

        private void Form_ComprarEntradas_Load(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                label1.Text = MainForm.PeliculaSeleccionada.Titulo;
            }
        }
    }
}
