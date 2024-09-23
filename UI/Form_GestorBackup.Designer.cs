namespace UI
{
    partial class Form_GestorBackup
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
            this.button_CrearBackup = new System.Windows.Forms.Button();
            this.button_RestaurarBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CrearBackup
            // 
            this.button_CrearBackup.Location = new System.Drawing.Point(12, 13);
            this.button_CrearBackup.Name = "button_CrearBackup";
            this.button_CrearBackup.Size = new System.Drawing.Size(102, 23);
            this.button_CrearBackup.TabIndex = 0;
            this.button_CrearBackup.Text = "Crear backup";
            this.button_CrearBackup.UseVisualStyleBackColor = true;
            this.button_CrearBackup.Click += new System.EventHandler(this.button_CrearBackup_Click);
            // 
            // button_RestaurarBackup
            // 
            this.button_RestaurarBackup.Location = new System.Drawing.Point(12, 42);
            this.button_RestaurarBackup.Name = "button_RestaurarBackup";
            this.button_RestaurarBackup.Size = new System.Drawing.Size(102, 23);
            this.button_RestaurarBackup.TabIndex = 1;
            this.button_RestaurarBackup.Text = "Restaurar backup";
            this.button_RestaurarBackup.UseVisualStyleBackColor = true;
            this.button_RestaurarBackup.Click += new System.EventHandler(this.button_RestaurarBackup_Click);
            // 
            // Form_GestorBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RestaurarBackup);
            this.Controls.Add(this.button_CrearBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GestionarBackup";
            this.Text = "Form_GestorBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GestorBackup_FormClosing);
            this.Load += new System.EventHandler(this.Form_GestorBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CrearBackup;
        private System.Windows.Forms.Button button_RestaurarBackup;
    }
}