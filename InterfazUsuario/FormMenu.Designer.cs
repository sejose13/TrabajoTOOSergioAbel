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
            this.menuItemDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosPrestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.documentosPrestadosToolStripMenuItem});
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(79, 24);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // menuItemDocumentos
            // 
            this.menuItemDocumentos.Name = "menuItemDocumentos";
            this.menuItemDocumentos.Size = new System.Drawing.Size(107, 26);
            this.menuItemDocumentos.Text = "Documentos";
            // 
            // menuItemEjemplares
            // 
            this.menuItemEjemplares.Name = "menuItemEjemplares";
            this.menuItemEjemplares.Size = new System.Drawing.Size(96, 26);
            this.menuItemEjemplares.Text = "Ejemplares";
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.Size = new System.Drawing.Size(91, 26);
            this.menuItemPrestamos.Text = "Préstamos";
            // 
            // menuItemConfiguracion
            // 
            this.menuItemConfiguracion.Name = "menuItemConfiguracion";
            this.menuItemConfiguracion.Size = new System.Drawing.Size(116, 26);
            this.menuItemConfiguracion.Text = "Configuración";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // documentosPrestadosToolStripMenuItem
            // 
            this.documentosPrestadosToolStripMenuItem.Name = "documentosPrestadosToolStripMenuItem";
            this.documentosPrestadosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.documentosPrestadosToolStripMenuItem.Text = "Documentos prestados";
            this.documentosPrestadosToolStripMenuItem.Click += new System.EventHandler(this.documentosPrestadosToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 552);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosPrestadosToolStripMenuItem;
    }
}