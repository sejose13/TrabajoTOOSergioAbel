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
            this.altaPrestamoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverPrestamoEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPrestamoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPrestamoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosPrestamoSinDevolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fueraDePlazoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarios1a1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
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
            this.documentosUsuarioPrestadosToolStripMenuItem,
            this.usuarios1a1ToolStripMenuItem});
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // altaUsuarioToolStripMenuItem
            // 
            this.altaUsuarioToolStripMenuItem.Name = "altaUsuarioToolStripMenuItem";
            this.altaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.altaUsuarioToolStripMenuItem.Text = "Alta";
            this.altaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaUsuarioToolStripMenuItem
            // 
            this.bajaUsuarioToolStripMenuItem.Name = "bajaUsuarioToolStripMenuItem";
            this.bajaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bajaUsuarioToolStripMenuItem.Text = "Baja";
            this.bajaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // listaUsuarioToolStripMenuItem
            // 
            this.listaUsuarioToolStripMenuItem.Name = "listaUsuarioToolStripMenuItem";
            this.listaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listaUsuarioToolStripMenuItem.Text = "Listado";
            this.listaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // documentosUsuarioPrestadosToolStripMenuItem
            // 
            this.documentosUsuarioPrestadosToolStripMenuItem.Name = "documentosUsuarioPrestadosToolStripMenuItem";
            this.documentosUsuarioPrestadosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
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
            this.menuItemDocumentos.Size = new System.Drawing.Size(87, 20);
            this.menuItemDocumentos.Text = "Documentos";
            // 
            // altaDocumentoToolStripMenuItem1
            // 
            this.altaDocumentoToolStripMenuItem1.Name = "altaDocumentoToolStripMenuItem1";
            this.altaDocumentoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.altaDocumentoToolStripMenuItem1.Text = "Alta";
            this.altaDocumentoToolStripMenuItem1.Click += new System.EventHandler(this.altaDocumentoToolStripMenuItem1_Click);
            // 
            // bajaDocumentoToolStripMenuItem1
            // 
            this.bajaDocumentoToolStripMenuItem1.Name = "bajaDocumentoToolStripMenuItem1";
            this.bajaDocumentoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.bajaDocumentoToolStripMenuItem1.Text = "Baja";
            this.bajaDocumentoToolStripMenuItem1.Click += new System.EventHandler(this.bajaDocumentoToolStripMenuItem1_Click);
            // 
            // listadoDocumentoToolStripMenuItem
            // 
            this.listadoDocumentoToolStripMenuItem.Name = "listadoDocumentoToolStripMenuItem";
            this.listadoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listadoDocumentoToolStripMenuItem.Text = "Listado";
            this.listadoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.listadoDocumentoToolStripMenuItem_Click);
            // 
            // másLeidoDocumentoToolStripMenuItem
            // 
            this.másLeidoDocumentoToolStripMenuItem.Name = "másLeidoDocumentoToolStripMenuItem";
            this.másLeidoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.másLeidoDocumentoToolStripMenuItem.Text = "Más leido";
            this.másLeidoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.másLeidoDocumentoToolStripMenuItem_Click);
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
            this.menuItemEjemplares.Size = new System.Drawing.Size(76, 20);
            this.menuItemEjemplares.Text = "Ejemplares";
            // 
            // altaEjemplarToolStripMenuItem2
            // 
            this.altaEjemplarToolStripMenuItem2.Name = "altaEjemplarToolStripMenuItem2";
            this.altaEjemplarToolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.altaEjemplarToolStripMenuItem2.Text = "Alta";
            this.altaEjemplarToolStripMenuItem2.Click += new System.EventHandler(this.altaEjemplarToolStripMenuItem2_Click);
            // 
            // bajaEjemplarToolStripMenuItem2
            // 
            this.bajaEjemplarToolStripMenuItem2.Name = "bajaEjemplarToolStripMenuItem2";
            this.bajaEjemplarToolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.bajaEjemplarToolStripMenuItem2.Text = "Baja";
            this.bajaEjemplarToolStripMenuItem2.Click += new System.EventHandler(this.bajaEjemplarToolStripMenuItem2_Click);
            // 
            // buscarEjemplarToolStripMenuItem1
            // 
            this.buscarEjemplarToolStripMenuItem1.Name = "buscarEjemplarToolStripMenuItem1";
            this.buscarEjemplarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.buscarEjemplarToolStripMenuItem1.Text = "Buscar";
            this.buscarEjemplarToolStripMenuItem1.Click += new System.EventHandler(this.buscarEjemplarToolStripMenuItem1_Click);
            // 
            // listadoEjemplarToolStripMenuItem1
            // 
            this.listadoEjemplarToolStripMenuItem1.Name = "listadoEjemplarToolStripMenuItem1";
            this.listadoEjemplarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.listadoEjemplarToolStripMenuItem1.Text = "Listado";
            this.listadoEjemplarToolStripMenuItem1.Click += new System.EventHandler(this.listadoEjemplarToolStripMenuItem1_Click);
            // 
            // disponibilidadEjemplarToolStripMenuItem
            // 
            this.disponibilidadEjemplarToolStripMenuItem.Name = "disponibilidadEjemplarToolStripMenuItem";
            this.disponibilidadEjemplarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.disponibilidadEjemplarToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadEjemplarToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadEjemplarToolStripMenuItem_Click);
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamoToolStripMenuItem3,
            this.devolverPrestamoEjemplarToolStripMenuItem,
            this.buscarPrestamoToolStripMenuItem2,
            this.listadoPrestamoToolStripMenuItem2,
            this.listadoPrestamoToolStripMenuItem,
            this.documentosPrestamoSinDevolverToolStripMenuItem,
            this.fueraDePlazoPrestamoToolStripMenuItem});
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.Size = new System.Drawing.Size(74, 20);
            this.menuItemPrestamos.Text = "Préstamos";
            // 
            // altaPrestamoToolStripMenuItem3
            // 
            this.altaPrestamoToolStripMenuItem3.Name = "altaPrestamoToolStripMenuItem3";
            this.altaPrestamoToolStripMenuItem3.Size = new System.Drawing.Size(208, 22);
            this.altaPrestamoToolStripMenuItem3.Text = "Alta";
            this.altaPrestamoToolStripMenuItem3.Click += new System.EventHandler(this.altaPrestamoToolStripMenuItem3_Click);
            // 
            // devolverPrestamoEjemplarToolStripMenuItem
            // 
            this.devolverPrestamoEjemplarToolStripMenuItem.Name = "devolverPrestamoEjemplarToolStripMenuItem";
            this.devolverPrestamoEjemplarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.devolverPrestamoEjemplarToolStripMenuItem.Text = "Devolver ejemplar";
            this.devolverPrestamoEjemplarToolStripMenuItem.Click += new System.EventHandler(this.devolverPrestamoEjemplarToolStripMenuItem_Click);
            // 
            // buscarPrestamoToolStripMenuItem2
            // 
            this.buscarPrestamoToolStripMenuItem2.Name = "buscarPrestamoToolStripMenuItem2";
            this.buscarPrestamoToolStripMenuItem2.Size = new System.Drawing.Size(208, 22);
            this.buscarPrestamoToolStripMenuItem2.Text = "Buscar";
            this.buscarPrestamoToolStripMenuItem2.Click += new System.EventHandler(this.buscarPrestamoToolStripMenuItem2_Click);
            // 
            // listadoPrestamoToolStripMenuItem2
            // 
            this.listadoPrestamoToolStripMenuItem2.Name = "listadoPrestamoToolStripMenuItem2";
            this.listadoPrestamoToolStripMenuItem2.Size = new System.Drawing.Size(208, 22);
            this.listadoPrestamoToolStripMenuItem2.Text = "Buscar usuario";
            this.listadoPrestamoToolStripMenuItem2.Click += new System.EventHandler(this.listadoPrestamoToolStripMenuItem2_Click);
            // 
            // listadoPrestamoToolStripMenuItem
            // 
            this.listadoPrestamoToolStripMenuItem.Name = "listadoPrestamoToolStripMenuItem";
            this.listadoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.listadoPrestamoToolStripMenuItem.Text = "Listado";
            this.listadoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.listadoPrestamoToolStripMenuItem_Click);
            // 
            // documentosPrestamoSinDevolverToolStripMenuItem
            // 
            this.documentosPrestamoSinDevolverToolStripMenuItem.Name = "documentosPrestamoSinDevolverToolStripMenuItem";
            this.documentosPrestamoSinDevolverToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.documentosPrestamoSinDevolverToolStripMenuItem.Text = "Documentos sin devolver";
            this.documentosPrestamoSinDevolverToolStripMenuItem.Click += new System.EventHandler(this.documentosPrestamoSinDevolverToolStripMenuItem_Click);
            // 
            // fueraDePlazoPrestamoToolStripMenuItem
            // 
            this.fueraDePlazoPrestamoToolStripMenuItem.Name = "fueraDePlazoPrestamoToolStripMenuItem";
            this.fueraDePlazoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.fueraDePlazoPrestamoToolStripMenuItem.Text = "Fuera de plazo";
            this.fueraDePlazoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.fueraDePlazoPrestamoToolStripMenuItem_Click);
            // 
            // menuItemConfiguracion
            // 
            this.menuItemConfiguracion.Name = "menuItemConfiguracion";
            this.menuItemConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.menuItemConfiguracion.Text = "Configuración";
            // 
            // usuarios1a1ToolStripMenuItem
            // 
            this.usuarios1a1ToolStripMenuItem.Name = "usuarios1a1ToolStripMenuItem";
            this.usuarios1a1ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.usuarios1a1ToolStripMenuItem.Text = "Usuarios1a1";
            this.usuarios1a1ToolStripMenuItem.Click += new System.EventHandler(this.usuarios1a1ToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(868, 448);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem altaPrestamoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem devolverPrestamoEjemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPrestamoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoPrestamoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosPrestamoSinDevolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fueraDePlazoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarios1a1ToolStripMenuItem;
    }
}