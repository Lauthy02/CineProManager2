﻿namespace UI
{
    partial class Form_BitacoraCambios
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
            this.button_RecomponerEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_RecomponerEstado
            // 
            this.button_RecomponerEstado.Location = new System.Drawing.Point(12, 69);
            this.button_RecomponerEstado.Name = "button_RecomponerEstado";
            this.button_RecomponerEstado.Size = new System.Drawing.Size(119, 23);
            this.button_RecomponerEstado.TabIndex = 1;
            this.button_RecomponerEstado.Text = "Recomponer estado";
            this.button_RecomponerEstado.UseVisualStyleBackColor = true;
            this.button_RecomponerEstado.Click += new System.EventHandler(this.button_RecomponerEstado_Click);
            // 
            // Form_BitacoraCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RecomponerEstado);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_BitacoraCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GestionarBitacoraCambios";
            this.Text = "Form_BitacoraCambios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_BitacoraCambios_FormClosing);
            this.Load += new System.EventHandler(this.Form_BitacoraCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_RecomponerEstado;
    }
}