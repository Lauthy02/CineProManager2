namespace UI
{
    partial class Form_ABMPeliculas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BuscarImagen = new System.Windows.Forms.Button();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.textBox_ImagenRuta = new System.Windows.Forms.TextBox();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Duracion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Director = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 481);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_BuscarImagen);
            this.groupBox1.Controls.Add(this.comboBox_Genero);
            this.groupBox1.Controls.Add(this.button_Modificacion);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.button_Baja);
            this.groupBox1.Controls.Add(this.button_Alta);
            this.groupBox1.Controls.Add(this.textBox_ImagenRuta);
            this.groupBox1.Controls.Add(this.textBox_Titulo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_Duracion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_Director);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "ABMPeliculas";
            this.groupBox1.Text = "ABM Películas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(7, 261);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 141);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Tag = "Descripcion";
            this.label1.Text = "Descripción: ";
            // 
            // button_BuscarImagen
            // 
            this.button_BuscarImagen.Enabled = false;
            this.button_BuscarImagen.Location = new System.Drawing.Point(4, 448);
            this.button_BuscarImagen.Name = "button_BuscarImagen";
            this.button_BuscarImagen.Size = new System.Drawing.Size(89, 23);
            this.button_BuscarImagen.TabIndex = 10;
            this.button_BuscarImagen.Tag = "BuscarImagen";
            this.button_BuscarImagen.Text = "Buscar imagen";
            this.button_BuscarImagen.UseVisualStyleBackColor = true;
            this.button_BuscarImagen.Click += new System.EventHandler(this.button_BuscarImagen_Click);
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.Enabled = false;
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Location = new System.Drawing.Point(5, 210);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(231, 21);
            this.comboBox_Genero.TabIndex = 9;
            // 
            // button_Modificacion
            // 
            this.button_Modificacion.Location = new System.Drawing.Point(163, 18);
            this.button_Modificacion.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modificacion.Name = "button_Modificacion";
            this.button_Modificacion.Size = new System.Drawing.Size(75, 23);
            this.button_Modificacion.TabIndex = 2;
            this.button_Modificacion.Tag = "Modificacion";
            this.button_Modificacion.Text = "Modificación";
            this.button_Modificacion.UseVisualStyleBackColor = true;
            this.button_Modificacion.Click += new System.EventHandler(this.button_Modificacion_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Enabled = false;
            this.button_Guardar.Location = new System.Drawing.Point(161, 447);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Tag = "Guardar";
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(84, 18);
            this.button_Baja.Margin = new System.Windows.Forms.Padding(2);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(75, 23);
            this.button_Baja.TabIndex = 1;
            this.button_Baja.Tag = "Baja";
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(5, 18);
            this.button_Alta.Margin = new System.Windows.Forms.Padding(2);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(75, 23);
            this.button_Alta.TabIndex = 0;
            this.button_Alta.Tag = "Alta";
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // textBox_ImagenRuta
            // 
            this.textBox_ImagenRuta.Enabled = false;
            this.textBox_ImagenRuta.Location = new System.Drawing.Point(4, 421);
            this.textBox_ImagenRuta.Name = "textBox_ImagenRuta";
            this.textBox_ImagenRuta.Size = new System.Drawing.Size(232, 20);
            this.textBox_ImagenRuta.TabIndex = 7;
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Enabled = false;
            this.textBox_Titulo.Location = new System.Drawing.Point(6, 68);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(232, 20);
            this.textBox_Titulo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Tag = "Imagen";
            this.label7.Text = "Imagen: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1;
            this.label11.Tag = "Titulo";
            this.label11.Text = "Título: ";
            // 
            // textBox_Duracion
            // 
            this.textBox_Duracion.Enabled = false;
            this.textBox_Duracion.Location = new System.Drawing.Point(6, 163);
            this.textBox_Duracion.Name = "textBox_Duracion";
            this.textBox_Duracion.Size = new System.Drawing.Size(232, 20);
            this.textBox_Duracion.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Tag = "Director";
            this.label10.Text = "Director: ";
            // 
            // textBox_Director
            // 
            this.textBox_Director.Enabled = false;
            this.textBox_Director.Location = new System.Drawing.Point(6, 116);
            this.textBox_Director.Name = "textBox_Director";
            this.textBox_Director.Size = new System.Drawing.Size(232, 20);
            this.textBox_Director.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 3;
            this.label9.Tag = "Duracion";
            this.label9.Text = "Duración (minutos): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Tag = "Genero";
            this.label8.Text = "Género: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Busca una imagen";
            // 
            // Form_ABMPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ABMPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ABMPeliculas";
            this.Text = "ABM de películas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ABMPeliculas_FormClosing);
            this.Load += new System.EventHandler(this.Form_ABMPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.TextBox textBox_ImagenRuta;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Duracion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Director;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.Button button_BuscarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}