namespace UI
{
    partial class Form_ABMFunciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_Salas = new System.Windows.Forms.ComboBox();
            this.comboBox_Pelicula = new System.Windows.Forms.ComboBox();
            this.comboBox_Horarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Horarios);
            this.groupBox1.Controls.Add(this.comboBox_Pelicula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.button_Modificacion);
            this.groupBox1.Controls.Add(this.button_Alta);
            this.groupBox1.Controls.Add(this.button_Baja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 242);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "ABMFunciones";
            this.groupBox1.Text = "ABM Funciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Tag = "Horario";
            this.label4.Text = "Horario";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Enabled = false;
            this.button_Guardar.Location = new System.Drawing.Point(163, 214);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 10;
            this.button_Guardar.Tag = "Guardar";
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Modificacion
            // 
            this.button_Modificacion.Location = new System.Drawing.Point(163, 27);
            this.button_Modificacion.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modificacion.Name = "button_Modificacion";
            this.button_Modificacion.Size = new System.Drawing.Size(75, 23);
            this.button_Modificacion.TabIndex = 9;
            this.button_Modificacion.Tag = "Modificacion";
            this.button_Modificacion.Text = "Modificación";
            this.button_Modificacion.UseVisualStyleBackColor = true;
            this.button_Modificacion.Click += new System.EventHandler(this.button_Modificacion_Click);
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(5, 27);
            this.button_Alta.Margin = new System.Windows.Forms.Padding(2);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(75, 23);
            this.button_Alta.TabIndex = 7;
            this.button_Alta.Tag = "Alta";
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(84, 27);
            this.button_Baja.Margin = new System.Windows.Forms.Padding(2);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(75, 23);
            this.button_Baja.TabIndex = 8;
            this.button_Baja.Tag = "Baja";
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Peliculas";
            this.label1.Text = "Película:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Tag = "Sala";
            this.label3.Text = "Sala: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 235);
            this.dataGridView1.TabIndex = 12;
            // 
            // comboBox_Salas
            // 
            this.comboBox_Salas.FormattingEnabled = true;
            this.comboBox_Salas.Location = new System.Drawing.Point(12, 23);
            this.comboBox_Salas.Name = "comboBox_Salas";
            this.comboBox_Salas.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Salas.TabIndex = 11;
            this.comboBox_Salas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Salas_SelectedIndexChanged);
            // 
            // comboBox_Pelicula
            // 
            this.comboBox_Pelicula.Enabled = false;
            this.comboBox_Pelicula.FormattingEnabled = true;
            this.comboBox_Pelicula.Location = new System.Drawing.Point(7, 80);
            this.comboBox_Pelicula.Name = "comboBox_Pelicula";
            this.comboBox_Pelicula.Size = new System.Drawing.Size(231, 21);
            this.comboBox_Pelicula.TabIndex = 12;
            // 
            // comboBox_Horarios
            // 
            this.comboBox_Horarios.Enabled = false;
            this.comboBox_Horarios.FormattingEnabled = true;
            this.comboBox_Horarios.Location = new System.Drawing.Point(7, 129);
            this.comboBox_Horarios.Name = "comboBox_Horarios";
            this.comboBox_Horarios.Size = new System.Drawing.Size(231, 21);
            this.comboBox_Horarios.TabIndex = 13;
            // 
            // Form_ABMFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Salas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ABMFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ABMFunciones";
            this.Text = "Form_ABMFunciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ABMFunciones_FormClosing);
            this.Load += new System.EventHandler(this.Form_ABMFunciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Salas;
        private System.Windows.Forms.ComboBox comboBox_Horarios;
        private System.Windows.Forms.ComboBox comboBox_Pelicula;
    }
}