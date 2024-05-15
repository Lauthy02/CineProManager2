namespace UI
{
    partial class Form_GestorPermisos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_GuardarRol = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ConfigurarRol = new System.Windows.Forms.Button();
            this.button_AgregarRol = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_GuardarNuevoRol = new System.Windows.Forms.Button();
            this.textBox_NombreNuevoRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.button_AgregarAccion = new System.Windows.Forms.Button();
            this.comboBox_Acciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_GuardarNuevaAccion = new System.Windows.Forms.Button();
            this.textBox_NombreNuevaAccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpPatentes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_GuardarRol);
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Location = new System.Drawing.Point(551, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(290, 249);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurar roles";
            // 
            // button_GuardarRol
            // 
            this.button_GuardarRol.Location = new System.Drawing.Point(11, 219);
            this.button_GuardarRol.Margin = new System.Windows.Forms.Padding(2);
            this.button_GuardarRol.Name = "button_GuardarRol";
            this.button_GuardarRol.Size = new System.Drawing.Size(96, 23);
            this.button_GuardarRol.TabIndex = 1;
            this.button_GuardarRol.Text = "Guardar rol";
            this.button_GuardarRol.UseVisualStyleBackColor = true;
            this.button_GuardarRol.Click += new System.EventHandler(this.button_GuardarRol_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 23);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(262, 192);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ConfigurarRol);
            this.groupBox2.Controls.Add(this.button_AgregarRol);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBox_Roles);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(280, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(258, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // button_ConfigurarRol
            // 
            this.button_ConfigurarRol.Location = new System.Drawing.Point(14, 63);
            this.button_ConfigurarRol.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigurarRol.Name = "button_ConfigurarRol";
            this.button_ConfigurarRol.Size = new System.Drawing.Size(96, 23);
            this.button_ConfigurarRol.TabIndex = 11;
            this.button_ConfigurarRol.Text = "Configurar";
            this.button_ConfigurarRol.UseVisualStyleBackColor = true;
            this.button_ConfigurarRol.Click += new System.EventHandler(this.button_ConfigurarRol_Click);
            // 
            // button_AgregarRol
            // 
            this.button_AgregarRol.Location = new System.Drawing.Point(117, 63);
            this.button_AgregarRol.Margin = new System.Windows.Forms.Padding(2);
            this.button_AgregarRol.Name = "button_AgregarRol";
            this.button_AgregarRol.Size = new System.Drawing.Size(96, 23);
            this.button_AgregarRol.TabIndex = 10;
            this.button_AgregarRol.Text = "Agregar >> ";
            this.button_AgregarRol.UseVisualStyleBackColor = true;
            this.button_AgregarRol.Click += new System.EventHandler(this.button_AgregarRol_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_GuardarNuevoRol);
            this.groupBox3.Controls.Add(this.textBox_NombreNuevoRol);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo rol";
            // 
            // button_GuardarNuevoRol
            // 
            this.button_GuardarNuevoRol.Location = new System.Drawing.Point(11, 61);
            this.button_GuardarNuevoRol.Margin = new System.Windows.Forms.Padding(2);
            this.button_GuardarNuevoRol.Name = "button_GuardarNuevoRol";
            this.button_GuardarNuevoRol.Size = new System.Drawing.Size(96, 23);
            this.button_GuardarNuevoRol.TabIndex = 4;
            this.button_GuardarNuevoRol.Text = "Guardar";
            this.button_GuardarNuevoRol.UseVisualStyleBackColor = true;
            this.button_GuardarNuevoRol.Click += new System.EventHandler(this.button_GuardarNuevoRol_Click);
            // 
            // textBox_NombreNuevoRol
            // 
            this.textBox_NombreNuevoRol.Location = new System.Drawing.Point(11, 37);
            this.textBox_NombreNuevoRol.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NombreNuevoRol.Name = "textBox_NombreNuevoRol";
            this.textBox_NombreNuevoRol.Size = new System.Drawing.Size(174, 20);
            this.textBox_NombreNuevoRol.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre: ";
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(15, 39);
            this.comboBox_Roles.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Roles.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Todos los roles: ";
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.button_AgregarAccion);
            this.grpPatentes.Controls.Add(this.comboBox_Acciones);
            this.grpPatentes.Controls.Add(this.label2);
            this.grpPatentes.Controls.Add(this.groupBox1);
            this.grpPatentes.Location = new System.Drawing.Point(11, 11);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(256, 249);
            this.grpPatentes.TabIndex = 7;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Text = "Acciones";
            // 
            // button_AgregarAccion
            // 
            this.button_AgregarAccion.Location = new System.Drawing.Point(11, 63);
            this.button_AgregarAccion.Margin = new System.Windows.Forms.Padding(2);
            this.button_AgregarAccion.Name = "button_AgregarAccion";
            this.button_AgregarAccion.Size = new System.Drawing.Size(96, 23);
            this.button_AgregarAccion.TabIndex = 8;
            this.button_AgregarAccion.Text = "Agregar >> ";
            this.button_AgregarAccion.UseVisualStyleBackColor = true;
            this.button_AgregarAccion.Click += new System.EventHandler(this.button_AgregarAccion_Click);
            // 
            // comboBox_Acciones
            // 
            this.comboBox_Acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Acciones.FormattingEnabled = true;
            this.comboBox_Acciones.Location = new System.Drawing.Point(11, 39);
            this.comboBox_Acciones.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Acciones.Name = "comboBox_Acciones";
            this.comboBox_Acciones.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Acciones.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todas las acciones: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_GuardarNuevaAccion);
            this.groupBox1.Controls.Add(this.textBox_NombreNuevaAccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva accion";
            // 
            // button_GuardarNuevaAccion
            // 
            this.button_GuardarNuevaAccion.Location = new System.Drawing.Point(16, 61);
            this.button_GuardarNuevaAccion.Margin = new System.Windows.Forms.Padding(2);
            this.button_GuardarNuevaAccion.Name = "button_GuardarNuevaAccion";
            this.button_GuardarNuevaAccion.Size = new System.Drawing.Size(96, 23);
            this.button_GuardarNuevaAccion.TabIndex = 4;
            this.button_GuardarNuevaAccion.Text = "Guardar";
            this.button_GuardarNuevaAccion.UseVisualStyleBackColor = true;
            this.button_GuardarNuevaAccion.Click += new System.EventHandler(this.button_GuardarNuevaAccion_Click);
            // 
            // textBox_NombreNuevaAccion
            // 
            this.textBox_NombreNuevaAccion.Location = new System.Drawing.Point(16, 37);
            this.textBox_NombreNuevaAccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NombreNuevaAccion.Name = "textBox_NombreNuevaAccion";
            this.textBox_NombreNuevaAccion.Size = new System.Drawing.Size(174, 20);
            this.textBox_NombreNuevaAccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre: ";
            // 
            // Form_GestorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 269);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPatentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GestorPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de permisos";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_GuardarRol;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ConfigurarRol;
        private System.Windows.Forms.Button button_AgregarRol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GuardarNuevoRol;
        private System.Windows.Forms.TextBox textBox_NombreNuevoRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button button_AgregarAccion;
        private System.Windows.Forms.ComboBox comboBox_Acciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_GuardarNuevaAccion;
        private System.Windows.Forms.TextBox textBox_NombreNuevaAccion;
        private System.Windows.Forms.Label label3;
    }
}