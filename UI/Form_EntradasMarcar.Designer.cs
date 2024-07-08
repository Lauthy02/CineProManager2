namespace UI
{
    partial class Form_EntradasMarcar
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
            this.button_VencerEntradas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_UtilizarEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_VencerEntradas
            // 
            this.button_VencerEntradas.Location = new System.Drawing.Point(12, 218);
            this.button_VencerEntradas.Name = "button_VencerEntradas";
            this.button_VencerEntradas.Size = new System.Drawing.Size(176, 23);
            this.button_VencerEntradas.TabIndex = 5;
            this.button_VencerEntradas.Tag = "EstablecerEntradaComoVencida";
            this.button_VencerEntradas.Text = "Establecer entrada como vencida";
            this.button_VencerEntradas.UseVisualStyleBackColor = true;
            this.button_VencerEntradas.Click += new System.EventHandler(this.button_VencerEntradas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(577, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_UtilizarEntrada
            // 
            this.button_UtilizarEntrada.Location = new System.Drawing.Point(413, 218);
            this.button_UtilizarEntrada.Name = "button_UtilizarEntrada";
            this.button_UtilizarEntrada.Size = new System.Drawing.Size(176, 23);
            this.button_UtilizarEntrada.TabIndex = 6;
            this.button_UtilizarEntrada.Tag = "EstablecerEntradaComoUtilizada";
            this.button_UtilizarEntrada.Text = "Establecer entrada como utilizada";
            this.button_UtilizarEntrada.UseVisualStyleBackColor = true;
            this.button_UtilizarEntrada.Click += new System.EventHandler(this.button_UtilizarEntrada_Click);
            // 
            // Form_EntradasMarcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 247);
            this.Controls.Add(this.button_UtilizarEntrada);
            this.Controls.Add(this.button_VencerEntradas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_EntradasMarcar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "MarcarEntradas";
            this.Text = "Form_EntradasMarcar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EntradasMarcar_FormClosing);
            this.Load += new System.EventHandler(this.Form_EntradasMarcar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_VencerEntradas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_UtilizarEntrada;
    }
}