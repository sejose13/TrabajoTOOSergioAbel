namespace InterfazUsuario
{
    partial class FormListadoUsuarios
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
            this.btnOrdenDni = new System.Windows.Forms.Button();
            this.btnOrdenNombre = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbDnis = new System.Windows.Forms.ListBox();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrdenDni
            // 
            this.btnOrdenDni.Location = new System.Drawing.Point(36, 33);
            this.btnOrdenDni.Name = "btnOrdenDni";
            this.btnOrdenDni.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenDni.TabIndex = 0;
            this.btnOrdenDni.Text = "DNI";
            this.btnOrdenDni.UseVisualStyleBackColor = true;
            // 
            // btnOrdenNombre
            // 
            this.btnOrdenNombre.Location = new System.Drawing.Point(176, 33);
            this.btnOrdenNombre.Name = "btnOrdenNombre";
            this.btnOrdenNombre.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenNombre.TabIndex = 1;
            this.btnOrdenNombre.Text = "Nombre";
            this.btnOrdenNombre.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(127, 289);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lbDnis
            // 
            this.lbDnis.FormattingEnabled = true;
            this.lbDnis.Location = new System.Drawing.Point(36, 96);
            this.lbDnis.Name = "lbDnis";
            this.lbDnis.Size = new System.Drawing.Size(120, 173);
            this.lbDnis.TabIndex = 3;
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(176, 96);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(120, 173);
            this.lbNombres.TabIndex = 4;
            // 
            // FormListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 332);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbDnis);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnOrdenNombre);
            this.Controls.Add(this.btnOrdenDni);
            this.Name = "FormListadoUsuarios";
            this.Text = "FormListadoUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenDni;
        private System.Windows.Forms.Button btnOrdenNombre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox lbDnis;
        private System.Windows.Forms.ListBox lbNombres;
    }
}