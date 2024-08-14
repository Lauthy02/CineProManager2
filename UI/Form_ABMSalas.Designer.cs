namespace UI
{
    partial class Form_ABMSalas
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
            this.comboBox_Cines = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SalaFormato = new System.Windows.Forms.ComboBox();
            this.textBox_SalaCapacidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_NroSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Cines
            // 
            this.comboBox_Cines.FormattingEnabled = true;
            this.comboBox_Cines.Location = new System.Drawing.Point(12, 25);
            this.comboBox_Cines.Name = "comboBox_Cines";
            this.comboBox_Cines.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Cines.TabIndex = 0;
            this.comboBox_Cines.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Capacidad";
            this.label1.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Formato";
            this.label2.Text = "Formato:";
            // 
            // comboBox_SalaFormato
            // 
            this.comboBox_SalaFormato.Enabled = false;
            this.comboBox_SalaFormato.FormattingEnabled = true;
            this.comboBox_SalaFormato.Location = new System.Drawing.Point(6, 179);
            this.comboBox_SalaFormato.Name = "comboBox_SalaFormato";
            this.comboBox_SalaFormato.Size = new System.Drawing.Size(232, 21);
            this.comboBox_SalaFormato.TabIndex = 3;
            // 
            // textBox_SalaCapacidad
            // 
            this.textBox_SalaCapacidad.Enabled = false;
            this.textBox_SalaCapacidad.Location = new System.Drawing.Point(6, 79);
            this.textBox_SalaCapacidad.Name = "textBox_SalaCapacidad";
            this.textBox_SalaCapacidad.Size = new System.Drawing.Size(232, 20);
            this.textBox_SalaCapacidad.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Tag = "Cine";
            this.label3.Text = "Cine: ";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Precio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_NroSala);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.button_Modificacion);
            this.groupBox1.Controls.Add(this.button_Alta);
            this.groupBox1.Controls.Add(this.button_Baja);
            this.groupBox1.Controls.Add(this.textBox_SalaCapacidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_SalaFormato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 286);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "ABMSalas";
            this.groupBox1.Text = "ABM Salas";
            // 
            // textBox_NroSala
            // 
            this.textBox_NroSala.Enabled = false;
            this.textBox_NroSala.Location = new System.Drawing.Point(6, 129);
            this.textBox_NroSala.Name = "textBox_NroSala";
            this.textBox_NroSala.Size = new System.Drawing.Size(232, 20);
            this.textBox_NroSala.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Tag = "NumeroDeSala";
            this.label4.Text = "Número de sala:";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(163, 258);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 10;
            this.button_Guardar.Tag = "Guardar";
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Tag = "Precio";
            this.label5.Text = "Precio: ";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Enabled = false;
            this.textBox_Precio.Location = new System.Drawing.Point(7, 233);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(231, 20);
            this.textBox_Precio.TabIndex = 14;
            this.textBox_Precio.Tag = "";
            // 
            // Form_ABMSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Cines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ABMSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ABMSalas";
            this.Text = "ABM de Salas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ABMSalas_FormClosing);
            this.Load += new System.EventHandler(this.Form_ABMSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_SalaFormato;
        private System.Windows.Forms.TextBox textBox_SalaCapacidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NroSala;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label5;
    }
}