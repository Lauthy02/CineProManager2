namespace UI
{
    partial class Form_EntradasEmitir
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
            this.button_EmitirEntradas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_EmitirEntradas
            // 
            this.button_EmitirEntradas.Location = new System.Drawing.Point(12, 218);
            this.button_EmitirEntradas.Name = "button_EmitirEntradas";
            this.button_EmitirEntradas.Size = new System.Drawing.Size(176, 23);
            this.button_EmitirEntradas.TabIndex = 3;
            this.button_EmitirEntradas.Tag = "EstablecerEntradaComoEmitida";
            this.button_EmitirEntradas.Text = "Establecer entrada como emitida";
            this.button_EmitirEntradas.UseVisualStyleBackColor = true;
            this.button_EmitirEntradas.Click += new System.EventHandler(this.button_EmitirEntradas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form_EntradasEmitir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 247);
            this.Controls.Add(this.button_EmitirEntradas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_EntradasEmitir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "EmitirEntradas";
            this.Text = "Form_EntradasEmitir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EntradasEmitir_FormClosing);
            this.Load += new System.EventHandler(this.Form_EntradasEmitir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_EmitirEntradas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}