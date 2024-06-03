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
            this.button_ComprarEntradas = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Cines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 424);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cines";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBox_Peliculas);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 352);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Películas";
            // 
            // button_ComprarEntradas
            // 
            this.button_ComprarEntradas.Enabled = false;
            this.button_ComprarEntradas.Location = new System.Drawing.Point(197, 278);
            this.button_ComprarEntradas.Name = "button_ComprarEntradas";
            this.button_ComprarEntradas.Size = new System.Drawing.Size(104, 23);
            this.button_ComprarEntradas.TabIndex = 5;
            this.button_ComprarEntradas.Text = "Comprar entradas";
            this.button_ComprarEntradas.UseVisualStyleBackColor = true;
            this.button_ComprarEntradas.Click += new System.EventHandler(this.button_ComprarEntradas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ComprarEntradas);
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
            this.groupBox3.Text = "Detalle de película";
            // 
            // richTextBox_Descripcion
            // 
            this.richTextBox_Descripcion.Location = new System.Drawing.Point(9, 157);
            this.richTextBox_Descripcion.Name = "richTextBox_Descripcion";
            this.richTextBox_Descripcion.ReadOnly = true;
            this.richTextBox_Descripcion.Size = new System.Drawing.Size(292, 115);
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
            this.label_Descripcion.Text = "Descripción: ";
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Location = new System.Drawing.Point(6, 109);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(48, 13);
            this.label_Genero.TabIndex = 4;
            this.label_Genero.Text = "Género: ";
            // 
            // label_Duracion
            // 
            this.label_Duracion.AutoSize = true;
            this.label_Duracion.Location = new System.Drawing.Point(6, 79);
            this.label_Duracion.Name = "label_Duracion";
            this.label_Duracion.Size = new System.Drawing.Size(101, 13);
            this.label_Duracion.TabIndex = 3;
            this.label_Duracion.Text = "Duración (minutos): ";
            // 
            // label_Director
            // 
            this.label_Director.AutoSize = true;
            this.label_Director.Location = new System.Drawing.Point(6, 49);
            this.label_Director.Name = "label_Director";
            this.label_Director.Size = new System.Drawing.Size(50, 13);
            this.label_Director.TabIndex = 2;
            this.label_Director.Text = "Director: ";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(6, 19);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(41, 13);
            this.label_Titulo.TabIndex = 1;
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
            this.label2.Text = "Seleccione una película: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
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
            // Form_Cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 440);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Cartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cartelera";
            this.Load += new System.EventHandler(this.Form_Cartelera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}