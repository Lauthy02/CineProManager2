namespace UI
{
    partial class Form_EntradasReservar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Funciones = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Salas = new System.Windows.Forms.ComboBox();
            this.groupBox_Butacas = new System.Windows.Forms.GroupBox();
            this.dataGridView_Butacas = new System.Windows.Forms.DataGridView();
            this.groupBox_DetalleEntrada = new System.Windows.Forms.GroupBox();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label_Butaca = new System.Windows.Forms.Label();
            this.label_Película = new System.Windows.Forms.Label();
            this.label_NumeroDeFuncion = new System.Windows.Forms.Label();
            this.label_NumeroDeSala = new System.Windows.Forms.Label();
            this.label_CineDireccion = new System.Windows.Forms.Label();
            this.label_Cine = new System.Windows.Forms.Label();
            this.label_Hora = new System.Windows.Forms.Label();
            this.label_Dia = new System.Windows.Forms.Label();
            this.label_Mes = new System.Windows.Forms.Label();
            this.label_Anio = new System.Windows.Forms.Label();
            this.button_ReservarEntradas = new System.Windows.Forms.Button();
            this.groupBox_Funciones = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Descripcion = new System.Windows.Forms.RichTextBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Genero = new System.Windows.Forms.Label();
            this.label_Duracion = new System.Windows.Forms.Label();
            this.label_Director = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Cines = new System.Windows.Forms.ComboBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Butacas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Butacas)).BeginInit();
            this.groupBox_DetalleEntrada.SuspendLayout();
            this.groupBox_Funciones.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Funciones
            // 
            this.listBox_Funciones.FormattingEnabled = true;
            this.listBox_Funciones.Location = new System.Drawing.Point(6, 39);
            this.listBox_Funciones.Name = "listBox_Funciones";
            this.listBox_Funciones.Size = new System.Drawing.Size(290, 303);
            this.listBox_Funciones.TabIndex = 2;
            this.listBox_Funciones.SelectedIndexChanged += new System.EventHandler(this.listBox_Funciones_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_Salas);
            this.groupBox1.Controls.Add(this.groupBox_Butacas);
            this.groupBox1.Controls.Add(this.groupBox_DetalleEntrada);
            this.groupBox1.Controls.Add(this.button_ReservarEntradas);
            this.groupBox1.Controls.Add(this.groupBox_Funciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Cines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 826);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Cines";
            this.groupBox1.Text = "Cines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 9;
            this.label7.Tag = "SeleccioneSala";
            this.label7.Text = "Seleccione una sala: ";
            // 
            // comboBox_Salas
            // 
            this.comboBox_Salas.FormattingEnabled = true;
            this.comboBox_Salas.Location = new System.Drawing.Point(196, 39);
            this.comboBox_Salas.Name = "comboBox_Salas";
            this.comboBox_Salas.Size = new System.Drawing.Size(184, 21);
            this.comboBox_Salas.TabIndex = 8;
            this.comboBox_Salas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Salas_SelectedIndexChanged);
            // 
            // groupBox_Butacas
            // 
            this.groupBox_Butacas.Controls.Add(this.dataGridView_Butacas);
            this.groupBox_Butacas.Location = new System.Drawing.Point(6, 423);
            this.groupBox_Butacas.Name = "groupBox_Butacas";
            this.groupBox_Butacas.Size = new System.Drawing.Size(1011, 368);
            this.groupBox_Butacas.TabIndex = 7;
            this.groupBox_Butacas.TabStop = false;
            this.groupBox_Butacas.Tag = "Butacas";
            this.groupBox_Butacas.Text = "Butacas";
            // 
            // dataGridView_Butacas
            // 
            this.dataGridView_Butacas.AllowUserToAddRows = false;
            this.dataGridView_Butacas.AllowUserToDeleteRows = false;
            this.dataGridView_Butacas.AllowUserToResizeColumns = false;
            this.dataGridView_Butacas.AllowUserToResizeRows = false;
            this.dataGridView_Butacas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_Butacas.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Butacas.MultiSelect = false;
            this.dataGridView_Butacas.Name = "dataGridView_Butacas";
            this.dataGridView_Butacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Butacas.Size = new System.Drawing.Size(756, 343);
            this.dataGridView_Butacas.TabIndex = 4;
            this.dataGridView_Butacas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Butacas_CellClick);
            // 
            // groupBox_DetalleEntrada
            // 
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Precio);
            this.groupBox_DetalleEntrada.Controls.Add(this.button_Confirmar);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Butaca);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Película);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_NumeroDeFuncion);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_NumeroDeSala);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_CineDireccion);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Cine);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Hora);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Dia);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Mes);
            this.groupBox_DetalleEntrada.Controls.Add(this.label_Anio);
            this.groupBox_DetalleEntrada.Location = new System.Drawing.Point(631, 67);
            this.groupBox_DetalleEntrada.Name = "groupBox_DetalleEntrada";
            this.groupBox_DetalleEntrada.Size = new System.Drawing.Size(386, 350);
            this.groupBox_DetalleEntrada.TabIndex = 6;
            this.groupBox_DetalleEntrada.TabStop = false;
            this.groupBox_DetalleEntrada.Text = "Detalle de la entrada";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(239, 321);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(141, 23);
            this.button_Confirmar.TabIndex = 11;
            this.button_Confirmar.Tag = "ConfirmarLoSeleccionado";
            this.button_Confirmar.Text = "Confirmar lo seleccionado";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // label_Butaca
            // 
            this.label_Butaca.AutoSize = true;
            this.label_Butaca.Location = new System.Drawing.Point(7, 283);
            this.label_Butaca.Name = "label_Butaca";
            this.label_Butaca.Size = new System.Drawing.Size(47, 13);
            this.label_Butaca.TabIndex = 10;
            this.label_Butaca.Tag = "Butaca";
            this.label_Butaca.Text = "Butaca: ";
            // 
            // label_Película
            // 
            this.label_Película.AutoSize = true;
            this.label_Película.Location = new System.Drawing.Point(7, 138);
            this.label_Película.Name = "label_Película";
            this.label_Película.Size = new System.Drawing.Size(52, 13);
            this.label_Película.TabIndex = 9;
            this.label_Película.Tag = "Pelicula";
            this.label_Película.Text = "Película: ";
            // 
            // label_NumeroDeFuncion
            // 
            this.label_NumeroDeFuncion.AutoSize = true;
            this.label_NumeroDeFuncion.Location = new System.Drawing.Point(7, 109);
            this.label_NumeroDeFuncion.Name = "label_NumeroDeFuncion";
            this.label_NumeroDeFuncion.Size = new System.Drawing.Size(100, 13);
            this.label_NumeroDeFuncion.TabIndex = 8;
            this.label_NumeroDeFuncion.Tag = "NumeroDeFuncion";
            this.label_NumeroDeFuncion.Text = "Número de función:";
            // 
            // label_NumeroDeSala
            // 
            this.label_NumeroDeSala.AutoSize = true;
            this.label_NumeroDeSala.Location = new System.Drawing.Point(7, 80);
            this.label_NumeroDeSala.Name = "label_NumeroDeSala";
            this.label_NumeroDeSala.Size = new System.Drawing.Size(84, 13);
            this.label_NumeroDeSala.TabIndex = 7;
            this.label_NumeroDeSala.Tag = "NumeroDeSala";
            this.label_NumeroDeSala.Text = "Número de sala:";
            // 
            // label_CineDireccion
            // 
            this.label_CineDireccion.AutoSize = true;
            this.label_CineDireccion.Location = new System.Drawing.Point(7, 51);
            this.label_CineDireccion.Name = "label_CineDireccion";
            this.label_CineDireccion.Size = new System.Drawing.Size(98, 13);
            this.label_CineDireccion.TabIndex = 6;
            this.label_CineDireccion.Tag = "Direccion";
            this.label_CineDireccion.Text = "Dirección del cine: ";
            // 
            // label_Cine
            // 
            this.label_Cine.AutoSize = true;
            this.label_Cine.Location = new System.Drawing.Point(7, 22);
            this.label_Cine.Name = "label_Cine";
            this.label_Cine.Size = new System.Drawing.Size(34, 13);
            this.label_Cine.TabIndex = 5;
            this.label_Cine.Tag = "Cine";
            this.label_Cine.Text = "Cine: ";
            // 
            // label_Hora
            // 
            this.label_Hora.AutoSize = true;
            this.label_Hora.Location = new System.Drawing.Point(7, 254);
            this.label_Hora.Name = "label_Hora";
            this.label_Hora.Size = new System.Drawing.Size(36, 13);
            this.label_Hora.TabIndex = 4;
            this.label_Hora.Tag = "Horario";
            this.label_Hora.Text = "Hora: ";
            // 
            // label_Dia
            // 
            this.label_Dia.AutoSize = true;
            this.label_Dia.Location = new System.Drawing.Point(7, 225);
            this.label_Dia.Name = "label_Dia";
            this.label_Dia.Size = new System.Drawing.Size(31, 13);
            this.label_Dia.TabIndex = 3;
            this.label_Dia.Tag = "Dia";
            this.label_Dia.Text = "Día: ";
            // 
            // label_Mes
            // 
            this.label_Mes.AutoSize = true;
            this.label_Mes.Location = new System.Drawing.Point(7, 196);
            this.label_Mes.Name = "label_Mes";
            this.label_Mes.Size = new System.Drawing.Size(33, 13);
            this.label_Mes.TabIndex = 2;
            this.label_Mes.Tag = "Mes";
            this.label_Mes.Text = "Mes: ";
            // 
            // label_Anio
            // 
            this.label_Anio.AutoSize = true;
            this.label_Anio.Location = new System.Drawing.Point(7, 167);
            this.label_Anio.Name = "label_Anio";
            this.label_Anio.Size = new System.Drawing.Size(32, 13);
            this.label_Anio.TabIndex = 1;
            this.label_Anio.Tag = "Anio";
            this.label_Anio.Text = "Año: ";
            // 
            // button_ReservarEntradas
            // 
            this.button_ReservarEntradas.Enabled = false;
            this.button_ReservarEntradas.Location = new System.Drawing.Point(913, 797);
            this.button_ReservarEntradas.Name = "button_ReservarEntradas";
            this.button_ReservarEntradas.Size = new System.Drawing.Size(104, 23);
            this.button_ReservarEntradas.TabIndex = 5;
            this.button_ReservarEntradas.Tag = "ReservarEntradas";
            this.button_ReservarEntradas.Text = "Reservar entradas";
            this.button_ReservarEntradas.UseVisualStyleBackColor = true;
            this.button_ReservarEntradas.Click += new System.EventHandler(this.button_ReservarEntradas_Click);
            // 
            // groupBox_Funciones
            // 
            this.groupBox_Funciones.Controls.Add(this.groupBox3);
            this.groupBox_Funciones.Controls.Add(this.label2);
            this.groupBox_Funciones.Controls.Add(this.listBox_Funciones);
            this.groupBox_Funciones.Location = new System.Drawing.Point(6, 66);
            this.groupBox_Funciones.Name = "groupBox_Funciones";
            this.groupBox_Funciones.Size = new System.Drawing.Size(619, 351);
            this.groupBox_Funciones.TabIndex = 2;
            this.groupBox_Funciones.TabStop = false;
            this.groupBox_Funciones.Tag = "Funciones";
            this.groupBox_Funciones.Text = "Funciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_Descripcion);
            this.groupBox3.Controls.Add(this.label_Descripcion);
            this.groupBox3.Controls.Add(this.label_Genero);
            this.groupBox3.Controls.Add(this.label_Duracion);
            this.groupBox3.Controls.Add(this.label_Director);
            this.groupBox3.Controls.Add(this.label_Titulo);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(308, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 306);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "DetallesPelicula";
            this.groupBox3.Text = "Detalles de la película";
            // 
            // richTextBox_Descripcion
            // 
            this.richTextBox_Descripcion.Location = new System.Drawing.Point(9, 157);
            this.richTextBox_Descripcion.Name = "richTextBox_Descripcion";
            this.richTextBox_Descripcion.ReadOnly = true;
            this.richTextBox_Descripcion.Size = new System.Drawing.Size(292, 143);
            this.richTextBox_Descripcion.TabIndex = 7;
            this.richTextBox_Descripcion.Text = "";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(6, 139);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(69, 13);
            this.label_Descripcion.TabIndex = 5;
            this.label_Descripcion.Tag = "Descripcion";
            this.label_Descripcion.Text = "Descripción: ";
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Location = new System.Drawing.Point(6, 109);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(48, 13);
            this.label_Genero.TabIndex = 4;
            this.label_Genero.Tag = "Genero";
            this.label_Genero.Text = "Género: ";
            // 
            // label_Duracion
            // 
            this.label_Duracion.AutoSize = true;
            this.label_Duracion.Location = new System.Drawing.Point(6, 79);
            this.label_Duracion.Name = "label_Duracion";
            this.label_Duracion.Size = new System.Drawing.Size(101, 13);
            this.label_Duracion.TabIndex = 3;
            this.label_Duracion.Tag = "Duracion";
            this.label_Duracion.Text = "Duración (minutos): ";
            // 
            // label_Director
            // 
            this.label_Director.AutoSize = true;
            this.label_Director.Location = new System.Drawing.Point(6, 49);
            this.label_Director.Name = "label_Director";
            this.label_Director.Size = new System.Drawing.Size(50, 13);
            this.label_Director.TabIndex = 2;
            this.label_Director.Tag = "Director";
            this.label_Director.Text = "Director: ";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(6, 19);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(41, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Tag = "Titulo";
            this.label_Titulo.Text = "Título: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "SeleccioneFuncion";
            this.label2.Text = "Seleccione una función: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "SeleccioneCine";
            this.label1.Text = "Seleccione un cine: ";
            // 
            // comboBox_Cines
            // 
            this.comboBox_Cines.FormattingEnabled = true;
            this.comboBox_Cines.Location = new System.Drawing.Point(6, 39);
            this.comboBox_Cines.Name = "comboBox_Cines";
            this.comboBox_Cines.Size = new System.Drawing.Size(184, 21);
            this.comboBox_Cines.TabIndex = 0;
            this.comboBox_Cines.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cines_SelectedIndexChanged);
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(7, 311);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(40, 13);
            this.label_Precio.TabIndex = 12;
            this.label_Precio.Tag = "Precio";
            this.label_Precio.Text = "Precio:";
            // 
            // Form_EntradasReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 841);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_EntradasReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Cartelera";
            this.Text = "Cartelera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Cartelera_FormClosing);
            this.Load += new System.EventHandler(this.Form_Cartelera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Butacas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Butacas)).EndInit();
            this.groupBox_DetalleEntrada.ResumeLayout(false);
            this.groupBox_DetalleEntrada.PerformLayout();
            this.groupBox_Funciones.ResumeLayout(false);
            this.groupBox_Funciones.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Funciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Cines;
        private System.Windows.Forms.GroupBox groupBox_Funciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_Descripcion;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Genero;
        private System.Windows.Forms.Label label_Duracion;
        private System.Windows.Forms.Label label_Director;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_ReservarEntradas;
        private System.Windows.Forms.GroupBox groupBox_Butacas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Salas;
        private System.Windows.Forms.GroupBox groupBox_DetalleEntrada;
        private System.Windows.Forms.Label label_Cine;
        private System.Windows.Forms.Label label_Hora;
        private System.Windows.Forms.Label label_Dia;
        private System.Windows.Forms.Label label_Mes;
        private System.Windows.Forms.Label label_Anio;
        private System.Windows.Forms.Label label_Butaca;
        private System.Windows.Forms.Label label_Película;
        private System.Windows.Forms.Label label_NumeroDeFuncion;
        private System.Windows.Forms.Label label_NumeroDeSala;
        private System.Windows.Forms.Label label_CineDireccion;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.DataGridView dataGridView_Butacas;
        private System.Windows.Forms.Label label_Precio;
    }
}