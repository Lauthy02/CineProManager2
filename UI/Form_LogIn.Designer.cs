namespace UI
{
    partial class Form_LogIn
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
            this.textBox_NombreDeUsuario = new System.Windows.Forms.TextBox();
            this.textBox_Contrasenia = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "NombreDeUsuario";
            this.label1.Text = "Nombre de usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Contrasenia";
            this.label2.Text = "Contraseña: ";
            // 
            // textBox_NombreDeUsuario
            // 
            this.textBox_NombreDeUsuario.Location = new System.Drawing.Point(122, 26);
            this.textBox_NombreDeUsuario.Name = "textBox_NombreDeUsuario";
            this.textBox_NombreDeUsuario.Size = new System.Drawing.Size(120, 20);
            this.textBox_NombreDeUsuario.TabIndex = 2;
            // 
            // textBox_Contrasenia
            // 
            this.textBox_Contrasenia.Location = new System.Drawing.Point(122, 53);
            this.textBox_Contrasenia.Name = "textBox_Contrasenia";
            this.textBox_Contrasenia.PasswordChar = '*';
            this.textBox_Contrasenia.Size = new System.Drawing.Size(120, 20);
            this.textBox_Contrasenia.TabIndex = 3;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(86, 83);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(75, 23);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Entrar";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // Form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 119);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Contrasenia);
            this.Controls.Add(this.textBox_NombreDeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "IniciarSesion";
            this.Text = "Iniciar sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_LogIn_FormClosing);
            this.Load += new System.EventHandler(this.Form_LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NombreDeUsuario;
        private System.Windows.Forms.TextBox textBox_Contrasenia;
        private System.Windows.Forms.Button button_LogIn;
    }
}