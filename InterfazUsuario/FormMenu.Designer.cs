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
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(79, 24);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // menuItemDocumentos
            // 
            this.menuItemDocumentos.Name = "menuItemDocumentos";
            this.menuItemDocumentos.Size = new System.Drawing.Size(107, 24);
            this.menuItemDocumentos.Text = "Documentos";
            // 
            // menuItemEjemplares
            // 
            this.menuItemEjemplares.Name = "menuItemEjemplares";
            this.menuItemEjemplares.Size = new System.Drawing.Size(96, 24);
            this.menuItemEjemplares.Text = "Ejemplares";
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.Size = new System.Drawing.Size(91, 24);
            this.menuItemPrestamos.Text = "Préstamos";
            // 
            // menuItemConfiguracion
            // 
            this.menuItemConfiguracion.Name = "menuItemConfiguracion";
            this.menuItemConfiguracion.Size = new System.Drawing.Size(116, 24);
            this.menuItemConfiguracion.Text = "Configuración";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 552);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
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
    }
}