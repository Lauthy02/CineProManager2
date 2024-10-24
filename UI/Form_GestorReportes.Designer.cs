namespace UI
{
    partial class Form_GestorReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CrearReporte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Cine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Sala = new System.Windows.Forms.ComboBox();
            this.comboBox_Pelicula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Producto = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_EspFecha = new System.Windows.Forms.CheckBox();
            this.checkBox_EspCine = new System.Windows.Forms.CheckBox();
            this.checkBox_EspSala = new System.Windows.Forms.CheckBox();
            this.checkBox_EspPelicula = new System.Windows.Forms.CheckBox();
            this.checkBox_EspProducto = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango de fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Película";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button_CrearReporte);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de reportes";
            // 
            // button_CrearReporte
            // 
            this.button_CrearReporte.Location = new System.Drawing.Point(403, 374);
            this.button_CrearReporte.Name = "button_CrearReporte";
            this.button_CrearReporte.Size = new System.Drawing.Size(85, 23);
            this.button_CrearReporte.TabIndex = 10;
            this.button_CrearReporte.Text = "Crear reporte";
            this.button_CrearReporte.UseVisualStyleBackColor = true;
            this.button_CrearReporte.Click += new System.EventHandler(this.button_CrearReporte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Calcular);
            this.groupBox2.Controls.Add(this.comboBox_Cine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_Sala);
            this.groupBox2.Controls.Add(this.comboBox_Pelicula);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_Producto);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(218, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 349);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_Cine
            // 
            this.comboBox_Cine.Enabled = false;
            this.comboBox_Cine.FormattingEnabled = true;
            this.comboBox_Cine.Location = new System.Drawing.Point(6, 209);
            this.comboBox_Cine.Name = "comboBox_Cine";
            this.comboBox_Cine.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cine.TabIndex = 9;
            this.comboBox_Cine.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cine";
            // 
            // comboBox_Sala
            // 
            this.comboBox_Sala.Enabled = false;
            this.comboBox_Sala.FormattingEnabled = true;
            this.comboBox_Sala.Location = new System.Drawing.Point(6, 248);
            this.comboBox_Sala.Name = "comboBox_Sala";
            this.comboBox_Sala.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Sala.TabIndex = 7;
            this.comboBox_Sala.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sala_SelectedIndexChanged);
            // 
            // comboBox_Pelicula
            // 
            this.comboBox_Pelicula.Enabled = false;
            this.comboBox_Pelicula.FormattingEnabled = true;
            this.comboBox_Pelicula.Location = new System.Drawing.Point(6, 292);
            this.comboBox_Pelicula.Name = "comboBox_Pelicula";
            this.comboBox_Pelicula.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Pelicula.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sala";
            // 
            // comboBox_Producto
            // 
            this.comboBox_Producto.Enabled = false;
            this.comboBox_Producto.FormattingEnabled = true;
            this.comboBox_Producto.Location = new System.Drawing.Point(133, 292);
            this.comboBox_Producto.Name = "comboBox_Producto";
            this.comboBox_Producto.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Producto.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 26);
            this.monthCalendar1.MaxSelectionCount = 60;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(6, 114);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(198, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Reportes de inventario de productos";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(6, 91);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(200, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Reportes de rendimiento por película";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(6, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(179, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Reportes de ocupación de salas";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Reportes de ventas de golosinas";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Reportes de ventas de entradas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 407);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Location = new System.Drawing.Point(182, 319);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.button_Calcular.TabIndex = 10;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_EspProducto);
            this.groupBox3.Controls.Add(this.checkBox_EspPelicula);
            this.groupBox3.Controls.Add(this.checkBox_EspSala);
            this.groupBox3.Controls.Add(this.checkBox_EspCine);
            this.groupBox3.Controls.Add(this.checkBox_EspFecha);
            this.groupBox3.Location = new System.Drawing.Point(7, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles";
            // 
            // checkBox_EspFecha
            // 
            this.checkBox_EspFecha.AutoSize = true;
            this.checkBox_EspFecha.Location = new System.Drawing.Point(6, 19);
            this.checkBox_EspFecha.Name = "checkBox_EspFecha";
            this.checkBox_EspFecha.Size = new System.Drawing.Size(108, 17);
            this.checkBox_EspFecha.TabIndex = 0;
            this.checkBox_EspFecha.Text = "Especificar fecha";
            this.checkBox_EspFecha.UseVisualStyleBackColor = true;
            this.checkBox_EspFecha.CheckedChanged += new System.EventHandler(this.checkBox_EspFecha_CheckedChanged);
            // 
            // checkBox_EspCine
            // 
            this.checkBox_EspCine.AutoSize = true;
            this.checkBox_EspCine.Location = new System.Drawing.Point(6, 42);
            this.checkBox_EspCine.Name = "checkBox_EspCine";
            this.checkBox_EspCine.Size = new System.Drawing.Size(101, 17);
            this.checkBox_EspCine.TabIndex = 1;
            this.checkBox_EspCine.Text = "Especificar cine";
            this.checkBox_EspCine.UseVisualStyleBackColor = true;
            this.checkBox_EspCine.CheckedChanged += new System.EventHandler(this.checkBox_EspCine_CheckedChanged);
            // 
            // checkBox_EspSala
            // 
            this.checkBox_EspSala.AutoSize = true;
            this.checkBox_EspSala.Enabled = false;
            this.checkBox_EspSala.Location = new System.Drawing.Point(6, 65);
            this.checkBox_EspSala.Name = "checkBox_EspSala";
            this.checkBox_EspSala.Size = new System.Drawing.Size(100, 17);
            this.checkBox_EspSala.TabIndex = 2;
            this.checkBox_EspSala.Text = "Especificar sala";
            this.checkBox_EspSala.UseVisualStyleBackColor = true;
            this.checkBox_EspSala.CheckedChanged += new System.EventHandler(this.checkBox_EspSala_CheckedChanged);
            // 
            // checkBox_EspPelicula
            // 
            this.checkBox_EspPelicula.AutoSize = true;
            this.checkBox_EspPelicula.Enabled = false;
            this.checkBox_EspPelicula.Location = new System.Drawing.Point(6, 88);
            this.checkBox_EspPelicula.Name = "checkBox_EspPelicula";
            this.checkBox_EspPelicula.Size = new System.Drawing.Size(119, 17);
            this.checkBox_EspPelicula.TabIndex = 3;
            this.checkBox_EspPelicula.Text = "Especificar película";
            this.checkBox_EspPelicula.UseVisualStyleBackColor = true;
            this.checkBox_EspPelicula.CheckedChanged += new System.EventHandler(this.checkBox_EspPelicula_CheckedChanged);
            // 
            // checkBox_EspProducto
            // 
            this.checkBox_EspProducto.AutoSize = true;
            this.checkBox_EspProducto.Enabled = false;
            this.checkBox_EspProducto.Location = new System.Drawing.Point(6, 111);
            this.checkBox_EspProducto.Name = "checkBox_EspProducto";
            this.checkBox_EspProducto.Size = new System.Drawing.Size(123, 17);
            this.checkBox_EspProducto.TabIndex = 4;
            this.checkBox_EspProducto.Text = "Especificar producto";
            this.checkBox_EspProducto.UseVisualStyleBackColor = true;
            this.checkBox_EspProducto.CheckedChanged += new System.EventHandler(this.checkBox_EspProducto_CheckedChanged);
            // 
            // Form_GestorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GestionarReportes";
            this.Text = "Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestorReportes_FormClosing);
            this.Load += new System.EventHandler(this.Form_GestorReportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.ComboBox comboBox_Pelicula;
        private System.Windows.Forms.ComboBox comboBox_Sala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CrearReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Cine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_EspProducto;
        private System.Windows.Forms.CheckBox checkBox_EspPelicula;
        private System.Windows.Forms.CheckBox checkBox_EspSala;
        private System.Windows.Forms.CheckBox checkBox_EspCine;
        private System.Windows.Forms.CheckBox checkBox_EspFecha;
    }
}