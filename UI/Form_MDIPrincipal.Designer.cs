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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MDIPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMFuncionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMGolosinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteleraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeGolosinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sesionToolStripMenuItem,
            this.gestoresToolStripMenuItem,
            this.cineToolStripMenuItem,
            this.idiomasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Tag = "menustrip";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Tag = "Sesion";
            this.sesionToolStripMenuItem.Text = "Sesión";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.iniciarSesionToolStripMenuItem.Tag = "IniciarSesion";
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Tag = "CerrarSesion";
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosDeUsuariosToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.gestionarCinesToolStripMenuItem,
            this.aBMUsuariosToolStripMenuItem,
            this.aBMPelículasToolStripMenuItem,
            this.aBMCinesToolStripMenuItem,
            this.aBMSalasToolStripMenuItem,
            this.aBMFuncionesToolStripMenuItem,
            this.aBMIdiomaToolStripMenuItem,
            this.aBMGolosinasToolStripMenuItem,
            this.bitacoraEventosToolStripMenuItem,
            this.bitacoraCambiosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.gestoresToolStripMenuItem.Tag = "Gestores";
            this.gestoresToolStripMenuItem.Text = "Gestores";
            // 
            // permisosDeUsuariosToolStripMenuItem
            // 
            this.permisosDeUsuariosToolStripMenuItem.Name = "permisosDeUsuariosToolStripMenuItem";
            this.permisosDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.permisosDeUsuariosToolStripMenuItem.Tag = "GestionarPermisosDeUsuarios";
            this.permisosDeUsuariosToolStripMenuItem.Text = "Gestionar permisos de usuarios";
            this.permisosDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.permisosDeUsuariosToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.permisosToolStripMenuItem.Tag = "GestionarPermisos";
            this.permisosToolStripMenuItem.Text = "Gestionar permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // gestionarCinesToolStripMenuItem
            // 
            this.gestionarCinesToolStripMenuItem.Name = "gestionarCinesToolStripMenuItem";
            this.gestionarCinesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.gestionarCinesToolStripMenuItem.Tag = "GestionarCines";
            this.gestionarCinesToolStripMenuItem.Text = "Gestionar cines";
            this.gestionarCinesToolStripMenuItem.Click += new System.EventHandler(this.gestionarCinesToolStripMenuItem_Click);
            // 
            // aBMUsuariosToolStripMenuItem
            // 
            this.aBMUsuariosToolStripMenuItem.Name = "aBMUsuariosToolStripMenuItem";
            this.aBMUsuariosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMUsuariosToolStripMenuItem.Tag = "ABMUsuarios";
            this.aBMUsuariosToolStripMenuItem.Text = "ABM Usuarios";
            this.aBMUsuariosToolStripMenuItem.Click += new System.EventHandler(this.aBMUsuariosToolStripMenuItem_Click);
            // 
            // aBMPelículasToolStripMenuItem
            // 
            this.aBMPelículasToolStripMenuItem.Name = "aBMPelículasToolStripMenuItem";
            this.aBMPelículasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMPelículasToolStripMenuItem.Tag = "ABMPeliculas";
            this.aBMPelículasToolStripMenuItem.Text = "ABM Películas";
            this.aBMPelículasToolStripMenuItem.Click += new System.EventHandler(this.aBMPelículasToolStripMenuItem_Click);
            // 
            // aBMCinesToolStripMenuItem
            // 
            this.aBMCinesToolStripMenuItem.Name = "aBMCinesToolStripMenuItem";
            this.aBMCinesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMCinesToolStripMenuItem.Tag = "ABMCines";
            this.aBMCinesToolStripMenuItem.Text = "ABM Cines";
            this.aBMCinesToolStripMenuItem.Click += new System.EventHandler(this.aBMCinesToolStripMenuItem_Click);
            // 
            // aBMSalasToolStripMenuItem
            // 
            this.aBMSalasToolStripMenuItem.Name = "aBMSalasToolStripMenuItem";
            this.aBMSalasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMSalasToolStripMenuItem.Tag = "ABMSalas";
            this.aBMSalasToolStripMenuItem.Text = "ABM Salas";
            this.aBMSalasToolStripMenuItem.Click += new System.EventHandler(this.aBMSalasToolStripMenuItem_Click);
            // 
            // aBMFuncionesToolStripMenuItem
            // 
            this.aBMFuncionesToolStripMenuItem.Name = "aBMFuncionesToolStripMenuItem";
            this.aBMFuncionesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMFuncionesToolStripMenuItem.Tag = "ABMFunciones";
            this.aBMFuncionesToolStripMenuItem.Text = "ABM Funciones";
            this.aBMFuncionesToolStripMenuItem.Click += new System.EventHandler(this.aBMFuncionesToolStripMenuItem_Click);
            // 
            // aBMIdiomaToolStripMenuItem
            // 
            this.aBMIdiomaToolStripMenuItem.Name = "aBMIdiomaToolStripMenuItem";
            this.aBMIdiomaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMIdiomaToolStripMenuItem.Tag = "ABMIdiomas";
            this.aBMIdiomaToolStripMenuItem.Text = "ABM Idioma";
            this.aBMIdiomaToolStripMenuItem.Click += new System.EventHandler(this.aBMIdiomaToolStripMenuItem_Click);
            // 
            // aBMGolosinasToolStripMenuItem
            // 
            this.aBMGolosinasToolStripMenuItem.Name = "aBMGolosinasToolStripMenuItem";
            this.aBMGolosinasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aBMGolosinasToolStripMenuItem.Tag = "ABMGolosinas";
            this.aBMGolosinasToolStripMenuItem.Text = "ABM Golosinas";
            this.aBMGolosinasToolStripMenuItem.Click += new System.EventHandler(this.aBMGolosinasToolStripMenuItem_Click);
            // 
            // bitacoraEventosToolStripMenuItem
            // 
            this.bitacoraEventosToolStripMenuItem.Name = "bitacoraEventosToolStripMenuItem";
            this.bitacoraEventosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.bitacoraEventosToolStripMenuItem.Tag = "GestionarBitacoraEventos";
            this.bitacoraEventosToolStripMenuItem.Text = "Bitacora eventos";
            this.bitacoraEventosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraEventosToolStripMenuItem_Click);
            // 
            // bitacoraCambiosToolStripMenuItem
            // 
            this.bitacoraCambiosToolStripMenuItem.Name = "bitacoraCambiosToolStripMenuItem";
            this.bitacoraCambiosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.bitacoraCambiosToolStripMenuItem.Tag = "GestionarBitacoraCambios";
            this.bitacoraCambiosToolStripMenuItem.Text = "Bitacora cambios de entradas";
            this.bitacoraCambiosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraCambiosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.backupToolStripMenuItem.Tag = "GestionarBackup";
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.reportesToolStripMenuItem.Tag = "GestionarReportes";
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // cineToolStripMenuItem
            // 
            this.cineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteleraToolStripMenuItem1,
            this.pagarEntradasToolStripMenuItem,
            this.emitirEntradasToolStripMenuItem,
            this.marcarEntradasToolStripMenuItem,
            this.ventaDeGolosinasToolStripMenuItem});
            this.cineToolStripMenuItem.Name = "cineToolStripMenuItem";
            this.cineToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.cineToolStripMenuItem.Tag = "Cine";
            this.cineToolStripMenuItem.Text = "Cine";
            // 
            // carteleraToolStripMenuItem1
            // 
            this.carteleraToolStripMenuItem1.Name = "carteleraToolStripMenuItem1";
            this.carteleraToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.carteleraToolStripMenuItem1.Tag = "ReservarEntradas";
            this.carteleraToolStripMenuItem1.Text = "Reservar entradas";
            this.carteleraToolStripMenuItem1.Click += new System.EventHandler(this.reservarEntradasToolStripMenuItem1_Click);
            // 
            // pagarEntradasToolStripMenuItem
            // 
            this.pagarEntradasToolStripMenuItem.Name = "pagarEntradasToolStripMenuItem";
            this.pagarEntradasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pagarEntradasToolStripMenuItem.Tag = "PagarEntradas";
            this.pagarEntradasToolStripMenuItem.Text = "Pagar entradas";
            this.pagarEntradasToolStripMenuItem.Click += new System.EventHandler(this.pagarEntradasToolStripMenuItem_Click);
            // 
            // emitirEntradasToolStripMenuItem
            // 
            this.emitirEntradasToolStripMenuItem.Name = "emitirEntradasToolStripMenuItem";
            this.emitirEntradasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.emitirEntradasToolStripMenuItem.Tag = "EmitirEntradas";
            this.emitirEntradasToolStripMenuItem.Text = "Emitir entradas";
            this.emitirEntradasToolStripMenuItem.Click += new System.EventHandler(this.emitirEntradasToolStripMenuItem_Click);
            // 
            // marcarEntradasToolStripMenuItem
            // 
            this.marcarEntradasToolStripMenuItem.Name = "marcarEntradasToolStripMenuItem";
            this.marcarEntradasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.marcarEntradasToolStripMenuItem.Tag = "MarcarEntradas";
            this.marcarEntradasToolStripMenuItem.Text = "Marcar entradas";
            this.marcarEntradasToolStripMenuItem.Click += new System.EventHandler(this.marcarEntradasToolStripMenuItem_Click);
            // 
            // ventaDeGolosinasToolStripMenuItem
            // 
            this.ventaDeGolosinasToolStripMenuItem.Name = "ventaDeGolosinasToolStripMenuItem";
            this.ventaDeGolosinasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ventaDeGolosinasToolStripMenuItem.Tag = "VentaGolosinas";
            this.ventaDeGolosinasToolStripMenuItem.Text = "Venta de golosinas";
            this.ventaDeGolosinasToolStripMenuItem.Click += new System.EventHandler(this.ventaDeGolosinasToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.idiomasToolStripMenuItem.Tag = "Idiomas";
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Sesion,
            this.toolStripStatusLabel_NomApe,
            this.toolStripStatusLabel_Rol,
            this.toolStripStatusLabel_Correo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Sesion
            // 
            this.toolStripStatusLabel_Sesion.Name = "toolStripStatusLabel_Sesion";
            this.toolStripStatusLabel_Sesion.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel_Sesion.Text = "[Status de sesión]";
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
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "MDIPrincipal";
            this.Text = "CineProManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MDIPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form_MDIPrincipal_Load);
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
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteleraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMCinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSalasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMFuncionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeGolosinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMGolosinasToolStripMenuItem;
    }
}

