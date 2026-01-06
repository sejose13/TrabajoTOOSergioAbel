namespace InterfazUsuario
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosUsuarioPrestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocumentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDocumentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másLeidoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEjemplarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEjemplarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEjemplarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEjemplarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUsuarios,
            this.menuItemDocumentos,
            this.menuItemEjemplares,
            this.menuItemPrestamos,
            this.menuItemConfiguracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemUsuarios
            // 
            this.menuItemUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUsuarioToolStripMenuItem,
            this.bajaUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem,
            this.listaUsuarioToolStripMenuItem,
            this.documentosUsuarioPrestadosToolStripMenuItem});
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(79, 24);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // altaUsuarioToolStripMenuItem
            // 
            this.altaUsuarioToolStripMenuItem.Name = "altaUsuarioToolStripMenuItem";
            this.altaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.altaUsuarioToolStripMenuItem.Text = "Alta";
            this.altaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaUsuarioToolStripMenuItem
            // 
            this.bajaUsuarioToolStripMenuItem.Name = "bajaUsuarioToolStripMenuItem";
            this.bajaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bajaUsuarioToolStripMenuItem.Text = "Baja";
            this.bajaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // listaUsuarioToolStripMenuItem
            // 
            this.listaUsuarioToolStripMenuItem.Name = "listaUsuarioToolStripMenuItem";
            this.listaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.listaUsuarioToolStripMenuItem.Text = "Listado";
            this.listaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // documentosUsuarioPrestadosToolStripMenuItem
            // 
            this.documentosUsuarioPrestadosToolStripMenuItem.Name = "documentosUsuarioPrestadosToolStripMenuItem";
            this.documentosUsuarioPrestadosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.documentosUsuarioPrestadosToolStripMenuItem.Text = "Documentos prestados";
            this.documentosUsuarioPrestadosToolStripMenuItem.Click += new System.EventHandler(this.documentosPrestadosToolStripMenuItem_Click);
            // 
            // menuItemDocumentos
            // 
            this.menuItemDocumentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocumentoToolStripMenuItem1,
            this.bajaDocumentoToolStripMenuItem1,
            this.listadoDocumentoToolStripMenuItem,
            this.másLeidoDocumentoToolStripMenuItem});
            this.menuItemDocumentos.Name = "menuItemDocumentos";
            this.menuItemDocumentos.Size = new System.Drawing.Size(107, 24);
            this.menuItemDocumentos.Text = "Documentos";
            // 
            // altaDocumentoToolStripMenuItem1
            // 
            this.altaDocumentoToolStripMenuItem1.Name = "altaDocumentoToolStripMenuItem1";
            this.altaDocumentoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.altaDocumentoToolStripMenuItem1.Text = "Alta";
            // 
            // bajaDocumentoToolStripMenuItem1
            // 
            this.bajaDocumentoToolStripMenuItem1.Name = "bajaDocumentoToolStripMenuItem1";
            this.bajaDocumentoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.bajaDocumentoToolStripMenuItem1.Text = "Baja";
            // 
            // listadoDocumentoToolStripMenuItem
            // 
            this.listadoDocumentoToolStripMenuItem.Name = "listadoDocumentoToolStripMenuItem";
            this.listadoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoDocumentoToolStripMenuItem.Text = "Listado";
            // 
            // másLeidoDocumentoToolStripMenuItem
            // 
            this.másLeidoDocumentoToolStripMenuItem.Name = "másLeidoDocumentoToolStripMenuItem";
            this.másLeidoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.másLeidoDocumentoToolStripMenuItem.Text = "Más leido";
            // 
            // menuItemEjemplares
            // 
            this.menuItemEjemplares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEjemplarToolStripMenuItem2,
            this.bajaEjemplarToolStripMenuItem2,
            this.buscarEjemplarToolStripMenuItem1,
            this.listadoEjemplarToolStripMenuItem1,
            this.disponibilidadEjemplarToolStripMenuItem});
            this.menuItemEjemplares.Name = "menuItemEjemplares";
            this.menuItemEjemplares.Size = new System.Drawing.Size(96, 24);
            this.menuItemEjemplares.Text = "Ejemplares";
            // 
            // altaEjemplarToolStripMenuItem2
            // 
            this.altaEjemplarToolStripMenuItem2.Name = "altaEjemplarToolStripMenuItem2";
            this.altaEjemplarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.altaEjemplarToolStripMenuItem2.Text = "Alta";
            // 
            // bajaEjemplarToolStripMenuItem2
            // 
            this.bajaEjemplarToolStripMenuItem2.Name = "bajaEjemplarToolStripMenuItem2";
            this.bajaEjemplarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.bajaEjemplarToolStripMenuItem2.Text = "Baja";
            // 
            // buscarEjemplarToolStripMenuItem1
            // 
            this.buscarEjemplarToolStripMenuItem1.Name = "buscarEjemplarToolStripMenuItem1";
            this.buscarEjemplarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.buscarEjemplarToolStripMenuItem1.Text = "Buscar";
            // 
            // listadoEjemplarToolStripMenuItem1
            // 
            this.listadoEjemplarToolStripMenuItem1.Name = "listadoEjemplarToolStripMenuItem1";
            this.listadoEjemplarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.listadoEjemplarToolStripMenuItem1.Text = "Listado";
            // 
            // disponibilidadEjemplarToolStripMenuItem
            // 
            this.disponibilidadEjemplarToolStripMenuItem.Name = "disponibilidadEjemplarToolStripMenuItem";
            this.disponibilidadEjemplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disponibilidadEjemplarToolStripMenuItem.Text = "Disponibilidad";
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem3,
            this.devolverEjemplarToolStripMenuItem,
            this.buscarToolStripMenuItem2,
            this.listadoToolStripMenuItem2,
            this.fToolStripMenuItem});
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.Size = new System.Drawing.Size(91, 24);
            this.menuItemPrestamos.Text = "Préstamos";
            // 
            // altaToolStripMenuItem3
            // 
            this.altaToolStripMenuItem3.Name = "altaToolStripMenuItem3";
            this.altaToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem3.Text = "Alta";
            // 
            // devolverEjemplarToolStripMenuItem
            // 
            this.devolverEjemplarToolStripMenuItem.Name = "devolverEjemplarToolStripMenuItem";
            this.devolverEjemplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.devolverEjemplarToolStripMenuItem.Text = "Devolver ejemplar";
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.buscarToolStripMenuItem2.Text = "Buscar";
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            this.listadoToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.listadoToolStripMenuItem2.Text = "Listado";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fToolStripMenuItem.Text = "F";
            // 
            // menuItemConfiguracion
            // 
            this.menuItemConfiguracion.Name = "menuItemConfiguracion";
            this.menuItemConfiguracion.Size = new System.Drawing.Size(116, 24);
            this.menuItemConfiguracion.Text = "Configuración";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1158, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuItemDocumentos;
        private System.Windows.Forms.ToolStripMenuItem menuItemEjemplares;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrestamos;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem altaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosUsuarioPrestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocumentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaDocumentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másLeidoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEjemplarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaEjemplarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarEjemplarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoEjemplarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadEjemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem devolverEjemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
    }
}