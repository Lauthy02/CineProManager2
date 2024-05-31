namespace UI
{
    partial class Form_ABMUsuarios
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
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Contrasenia = new System.Windows.Forms.TextBox();
            this.textBox_NombreDeUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Modificacion);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.button_Baja);
            this.groupBox1.Controls.Add(this.button_Alta);
            this.groupBox1.Controls.Add(this.textBox_Correo);
            this.groupBox1.Controls.Add(this.textBox_Contrasenia);
            this.groupBox1.Controls.Add(this.textBox_NombreDeUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM Usuarios";
            // 
            // button_Modificacion
            // 
            this.button_Modificacion.Location = new System.Drawing.Point(163, 18);
            this.button_Modificacion.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modificacion.Name = "button_Modificacion";
            this.button_Modificacion.Size = new System.Drawing.Size(75, 23);
            this.button_Modificacion.TabIndex = 2;
            this.button_Modificacion.Text = "Modificación";
            this.button_Modificacion.UseVisualStyleBackColor = true;
            this.button_Modificacion.Click += new System.EventHandler(this.button_Modificacion_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Enabled = false;
            this.button_Guardar.Location = new System.Drawing.Point(163, 283);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 8;
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
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Enabled = false;
            this.textBox_Correo.Location = new System.Drawing.Point(6, 257);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(232, 20);
            this.textBox_Correo.TabIndex = 7;
            // 
            // textBox_Contrasenia
            // 
            this.textBox_Contrasenia.Enabled = false;
            this.textBox_Contrasenia.Location = new System.Drawing.Point(6, 210);
            this.textBox_Contrasenia.Name = "textBox_Contrasenia";
            this.textBox_Contrasenia.Size = new System.Drawing.Size(232, 20);
            this.textBox_Contrasenia.TabIndex = 6;
            // 
            // textBox_NombreDeUsuario
            // 
            this.textBox_NombreDeUsuario.Enabled = false;
            this.textBox_NombreDeUsuario.Location = new System.Drawing.Point(6, 68);
            this.textBox_NombreDeUsuario.Name = "textBox_NombreDeUsuario";
            this.textBox_NombreDeUsuario.Size = new System.Drawing.Size(232, 20);
            this.textBox_NombreDeUsuario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Correo electrónico: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre de usuario: ";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Enabled = false;
            this.textBox_Apellido.Location = new System.Drawing.Point(6, 163);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre: ";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Enabled = false;
            this.textBox_Nombre.Location = new System.Drawing.Point(6, 116);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Apellido:  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contraseña: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form_ABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ABMUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_NombreDeUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_Contrasenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Alta;
    }
}