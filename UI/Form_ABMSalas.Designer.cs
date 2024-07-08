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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Cines
            // 
            this.comboBox_Cines.FormattingEnabled = true;
            this.comboBox_Cines.Location = new System.Drawing.Point(12, 30);
            this.comboBox_Cines.Name = "comboBox_Cines";
            this.comboBox_Cines.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Cines.TabIndex = 0;
            this.comboBox_Cines.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formato:";
            // 
            // comboBox_SalaFormato
            // 
            this.comboBox_SalaFormato.FormattingEnabled = true;
            this.comboBox_SalaFormato.Location = new System.Drawing.Point(26, 157);
            this.comboBox_SalaFormato.Name = "comboBox_SalaFormato";
            this.comboBox_SalaFormato.Size = new System.Drawing.Size(150, 21);
            this.comboBox_SalaFormato.TabIndex = 3;
            // 
            // textBox_SalaCapacidad
            // 
            this.textBox_SalaCapacidad.Location = new System.Drawing.Point(26, 112);
            this.textBox_SalaCapacidad.Name = "textBox_SalaCapacidad";
            this.textBox_SalaCapacidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_SalaCapacidad.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form_ABMSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_SalaCapacidad);
            this.Controls.Add(this.comboBox_SalaFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Cines);
            this.Name = "Form_ABMSalas";
            this.Tag = "ABMSalas";
            this.Text = "ABM de Salas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ABMSalas_FormClosing);
            this.Load += new System.EventHandler(this.Form_ABMSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}