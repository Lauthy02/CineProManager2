namespace UI
{
    partial class Form_Cartelera
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
            this.listBox_Peliculas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ComprarEntradas = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Horarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Peliculas
            // 
            this.listBox_Peliculas.FormattingEnabled = true;
            this.listBox_Peliculas.Location = new System.Drawing.Point(6, 39);
            this.listBox_Peliculas.Name = "listBox_Peliculas";
            this.listBox_Peliculas.Size = new System.Drawing.Size(192, 303);
            this.listBox_Peliculas.TabIndex = 2;
            this.listBox_Peliculas.SelectedIndexChanged += new System.EventHandler(this.listBox_Peliculas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button_ComprarEntradas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Cines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 708);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Cines";
            this.groupBox1.Text = "Cines";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBox_Peliculas);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 351);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Peliculas";
            this.groupBox2.Text = "Películas";
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
            this.groupBox3.Location = new System.Drawing.Point(204, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 306);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "DetallesPelicula";
            this.groupBox3.Text = "Detalles de la película";
            // 
            // button_ComprarEntradas
            // 
            this.button_ComprarEntradas.Enabled = false;
            this.button_ComprarEntradas.Location = new System.Drawing.Point(913, 679);
            this.button_ComprarEntradas.Name = "button_ComprarEntradas";
            this.button_ComprarEntradas.Size = new System.Drawing.Size(104, 23);
            this.button_ComprarEntradas.TabIndex = 5;
            this.button_ComprarEntradas.Tag = "ReservarEntradas";
            this.button_ComprarEntradas.Text = "Reservar entradas";
            this.button_ComprarEntradas.UseVisualStyleBackColor = true;
            this.button_ComprarEntradas.Click += new System.EventHandler(this.button_ComprarEntradas_Click);
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
            this.label_Descripcion.Tag = "Drescripcion";
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
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "SeleccionePelicula";
            this.label2.Text = "Seleccione una película: ";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_Horarios);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(528, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 350);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horarios";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 423);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(985, 250);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Butacas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mes: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Día: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hora: ";
            // 
            // comboBox_Horarios
            // 
            this.comboBox_Horarios.FormattingEnabled = true;
            this.comboBox_Horarios.Location = new System.Drawing.Point(6, 144);
            this.comboBox_Horarios.Name = "comboBox_Horarios";
            this.comboBox_Horarios.Size = new System.Drawing.Size(201, 21);
            this.comboBox_Horarios.TabIndex = 5;
            // 
            // Form_Cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 850);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Cartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Cartelera";
            this.Text = "Cartelera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Cartelera_FormClosing);
            this.Load += new System.EventHandler(this.Form_Cartelera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Peliculas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Cines;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button button_ComprarEntradas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Horarios;
    }
}