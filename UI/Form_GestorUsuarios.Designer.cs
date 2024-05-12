namespace UI
{
    partial class Form_GestorUsuarios
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
            this.button_GuardarCambios = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.button_AgregarRol = new System.Windows.Forms.Button();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AgregarAccion = new System.Windows.Forms.Button();
            this.comboBox_Acciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ConfigurarUsuario = new System.Windows.Forms.Button();
            this.comboBox_Usuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPatentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GuardarCambios
            // 
            this.button_GuardarCambios.Location = new System.Drawing.Point(283, 241);
            this.button_GuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.button_GuardarCambios.Name = "button_GuardarCambios";
            this.button_GuardarCambios.Size = new System.Drawing.Size(96, 23);
            this.button_GuardarCambios.TabIndex = 10;
            this.button_GuardarCambios.Text = "Guardar cambios";
            this.button_GuardarCambios.UseVisualStyleBackColor = true;
            this.button_GuardarCambios.Click += new System.EventHandler(this.button_GuardarCambios_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(283, 21);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(276, 213);
            this.treeView1.TabIndex = 9;
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.button_AgregarRol);
            this.grpPatentes.Controls.Add(this.comboBox_Roles);
            this.grpPatentes.Controls.Add(this.label3);
            this.grpPatentes.Controls.Add(this.button_AgregarAccion);
            this.grpPatentes.Controls.Add(this.comboBox_Acciones);
            this.grpPatentes.Controls.Add(this.label1);
            this.grpPatentes.Controls.Add(this.button_ConfigurarUsuario);
            this.grpPatentes.Controls.Add(this.comboBox_Usuarios);
            this.grpPatentes.Controls.Add(this.label2);
            this.grpPatentes.Location = new System.Drawing.Point(11, 11);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(256, 249);
            this.grpPatentes.TabIndex = 8;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Text = "Usuarios";
            // 
            // button_AgregarRol
            // 
            this.button_AgregarRol.Location = new System.Drawing.Point(11, 219);
            this.button_AgregarRol.Margin = new System.Windows.Forms.Padding(2);
            this.button_AgregarRol.Name = "button_AgregarRol";
            this.button_AgregarRol.Size = new System.Drawing.Size(75, 23);
            this.button_AgregarRol.TabIndex = 13;
            this.button_AgregarRol.Text = "Agregar >>";
            this.button_AgregarRol.UseVisualStyleBackColor = true;
            this.button_AgregarRol.Click += new System.EventHandler(this.button_AgregarRol_Click);
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(11, 194);
            this.comboBox_Roles.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Roles.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Agregar roles:";
            // 
            // button_AgregarAccion
            // 
            this.button_AgregarAccion.Location = new System.Drawing.Point(11, 151);
            this.button_AgregarAccion.Margin = new System.Windows.Forms.Padding(2);
            this.button_AgregarAccion.Name = "button_AgregarAccion";
            this.button_AgregarAccion.Size = new System.Drawing.Size(75, 23);
            this.button_AgregarAccion.TabIndex = 10;
            this.button_AgregarAccion.Text = "Agregar >>";
            this.button_AgregarAccion.UseVisualStyleBackColor = true;
            this.button_AgregarAccion.Click += new System.EventHandler(this.button_AgregarAccion_Click);
            // 
            // comboBox_Acciones
            // 
            this.comboBox_Acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Acciones.FormattingEnabled = true;
            this.comboBox_Acciones.Location = new System.Drawing.Point(11, 127);
            this.comboBox_Acciones.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Acciones.Name = "comboBox_Acciones";
            this.comboBox_Acciones.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Acciones.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar acciones:";
            // 
            // button_ConfigurarUsuario
            // 
            this.button_ConfigurarUsuario.Location = new System.Drawing.Point(11, 63);
            this.button_ConfigurarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigurarUsuario.Name = "button_ConfigurarUsuario";
            this.button_ConfigurarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_ConfigurarUsuario.TabIndex = 7;
            this.button_ConfigurarUsuario.Text = "Configurar";
            this.button_ConfigurarUsuario.UseVisualStyleBackColor = true;
            this.button_ConfigurarUsuario.Click += new System.EventHandler(this.button_ConfigurarUsuario_Click);
            // 
            // comboBox_Usuarios
            // 
            this.comboBox_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Usuarios.FormattingEnabled = true;
            this.comboBox_Usuarios.Location = new System.Drawing.Point(11, 39);
            this.comboBox_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Usuarios.Name = "comboBox_Usuarios";
            this.comboBox_Usuarios.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Usuarios.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos los usuarios";
            // 
            // Form_GestorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 272);
            this.Controls.Add(this.button_GuardarCambios);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpPatentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GestorUsuarios";
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GuardarCambios;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button button_AgregarRol;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AgregarAccion;
        private System.Windows.Forms.ComboBox comboBox_Acciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ConfigurarUsuario;
        private System.Windows.Forms.ComboBox comboBox_Usuarios;
        private System.Windows.Forms.Label label2;
    }
}