namespace Controles
{
    partial class FrmInicio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboEjemplos = new System.Windows.Forms.ComboBox();
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.grpSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(34, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ejemplo:";
            // 
            // cboEjemplos
            // 
            this.cboEjemplos.FormattingEnabled = true;
            this.cboEjemplos.Location = new System.Drawing.Point(87, 46);
            this.cboEjemplos.Name = "cboEjemplos";
            this.cboEjemplos.Size = new System.Drawing.Size(199, 21);
            this.cboEjemplos.TabIndex = 0;
            this.cboEjemplos.SelectedIndexChanged += new System.EventHandler(this.cboEjemplos_SelectedIndexChanged);
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.lblTitulo);
            this.grpSeleccion.Controls.Add(this.cboEjemplos);
            this.grpSeleccion.Location = new System.Drawing.Point(15, 16);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(351, 120);
            this.grpSeleccion.TabIndex = 2;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Seleccionar Ejemplo";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 153);
            this.Controls.Add(this.grpSeleccion);
            this.Name = "FrmInicio";
            this.Text = "INICIO DEL EJEMPLO";
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.ComboBox cboEjemplos;
        internal System.Windows.Forms.GroupBox grpSeleccion;
    }
}

