namespace UI
{
    partial class Form_GestorCines
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
            this.comboBox_Cines = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Salas = new System.Windows.Forms.ListBox();
            this.listBox_Funciones = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Cartelera = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Cines);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Cine";
            this.groupBox1.Text = "Cine";
            // 
            // comboBox_Cines
            // 
            this.comboBox_Cines.FormattingEnabled = true;
            this.comboBox_Cines.Location = new System.Drawing.Point(6, 19);
            this.comboBox_Cines.Name = "comboBox_Cines";
            this.comboBox_Cines.Size = new System.Drawing.Size(160, 21);
            this.comboBox_Cines.TabIndex = 3;
            this.comboBox_Cines.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cines_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Cartelera);
            this.groupBox2.Location = new System.Drawing.Point(398, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Cartelera";
            this.groupBox2.Text = "Cartelera";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Salas);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 304);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "Salas";
            this.groupBox3.Text = "Salas";
            // 
            // listBox_Salas
            // 
            this.listBox_Salas.FormattingEnabled = true;
            this.listBox_Salas.Location = new System.Drawing.Point(7, 20);
            this.listBox_Salas.Name = "listBox_Salas";
            this.listBox_Salas.Size = new System.Drawing.Size(176, 277);
            this.listBox_Salas.TabIndex = 3;
            this.listBox_Salas.SelectedIndexChanged += new System.EventHandler(this.listBox_Salas_SelectedIndexChanged);
            // 
            // listBox_Funciones
            // 
            this.listBox_Funciones.FormattingEnabled = true;
            this.listBox_Funciones.Location = new System.Drawing.Point(6, 19);
            this.listBox_Funciones.Name = "listBox_Funciones";
            this.listBox_Funciones.Size = new System.Drawing.Size(176, 251);
            this.listBox_Funciones.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Funciones);
            this.groupBox4.Location = new System.Drawing.Point(189, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 283);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "Funciones";
            this.groupBox4.Text = "Funciones";
            // 
            // listBox_Cartelera
            // 
            this.listBox_Cartelera.FormattingEnabled = true;
            this.listBox_Cartelera.Location = new System.Drawing.Point(6, 20);
            this.listBox_Cartelera.Name = "listBox_Cartelera";
            this.listBox_Cartelera.Size = new System.Drawing.Size(176, 277);
            this.listBox_Cartelera.TabIndex = 5;
            // 
            // Form_GestorCines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 375);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorCines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GestionarCines";
            this.Text = "Gestor de cines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestorCines_FormClosing);
            this.Load += new System.EventHandler(this.Form_GestorCines_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Cines;
        private System.Windows.Forms.ListBox listBox_Cartelera;
        private System.Windows.Forms.ListBox listBox_Salas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_Funciones;
    }
}