namespace UI
{
    partial class Form_GestorSerializar
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
            this.button_Deserializar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Deserializar
            // 
            this.button_Deserializar.Location = new System.Drawing.Point(40, 56);
            this.button_Deserializar.Name = "button_Deserializar";
            this.button_Deserializar.Size = new System.Drawing.Size(75, 23);
            this.button_Deserializar.TabIndex = 0;
            this.button_Deserializar.Text = "Deserializar";
            this.button_Deserializar.UseVisualStyleBackColor = true;
            this.button_Deserializar.Click += new System.EventHandler(this.button_Deserializar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form_GestorSerializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 182);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Deserializar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorSerializar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GestionarSerializacion";
            this.Text = "Gestor serializar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestorSerializar_FormClosing);
            this.Load += new System.EventHandler(this.Form_GestorSerializar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Deserializar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}