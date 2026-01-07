namespace InterfazUsuario
{
    partial class FormListadoEjemplares
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
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.AllowUserToAddRows = false;
            this.dgvEjemplares.AllowUserToDeleteRows = false;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Location = new System.Drawing.Point(12, 12);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.ReadOnly = true;
            this.dgvEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjemplares.Size = new System.Drawing.Size(764, 320);
            this.dgvEjemplares.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(366, 360);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormListadoEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvEjemplares);
            this.Name = "FormListadoEjemplares";
            this.Text = "Listado de Ejemplares";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEjemplares;
        private System.Windows.Forms.Button btnCerrar;
    }
}