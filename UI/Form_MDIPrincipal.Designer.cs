namespace UI
{
    partial class Form_MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Sesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_NomApe = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Correo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesión";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Sesion,
            this.toolStripStatusLabel_NomApe,
            this.toolStripStatusLabel_Rol,
            this.toolStripStatusLabel_Correo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Sesion
            // 
            this.toolStripStatusLabel_Sesion.Name = "toolStripStatusLabel_Sesion";
            this.toolStripStatusLabel_Sesion.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel_Sesion.Text = "[No hay sesión iniciada]";
            // 
            // toolStripStatusLabel_NomApe
            // 
            this.toolStripStatusLabel_NomApe.Name = "toolStripStatusLabel_NomApe";
            this.toolStripStatusLabel_NomApe.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel_NomApe.Text = "[Nombre Apellido]";
            // 
            // toolStripStatusLabel_Rol
            // 
            this.toolStripStatusLabel_Rol.Name = "toolStripStatusLabel_Rol";
            this.toolStripStatusLabel_Rol.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel_Rol.Text = "[Rol]";
            // 
            // toolStripStatusLabel_Correo
            // 
            this.toolStripStatusLabel_Correo.Name = "toolStripStatusLabel_Correo";
            this.toolStripStatusLabel_Correo.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel_Correo.Text = "[Correo]";
            // 
            // Form_MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineProManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Sesion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_NomApe;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Rol;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Correo;
    }
}

