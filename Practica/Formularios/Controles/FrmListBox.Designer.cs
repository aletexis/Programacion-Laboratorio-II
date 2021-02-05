namespace Controles
{
    partial class FrmListBox
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
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccinarCod = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.chkColumnas = new System.Windows.Forms.CheckBox();
            this.chkOrdenar = new System.Windows.Forms.CheckBox();
            this.rdoExtendida = new System.Windows.Forms.RadioButton();
            this.rdoMultiple = new System.Windows.Forms.RadioButton();
            this.rdoUno = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstValores = new System.Windows.Forms.ListBox();
            this.lstTraspaso = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(377, 230);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(36, 13);
            this.lblIndice.TabIndex = 41;
            this.lblIndice.Text = "Índice";
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(6, 230);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(51, 13);
            this.lblElemento.TabIndex = 40;
            this.lblElemento.Text = "Elemento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(380, 246);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 39;
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.AutoSize = true;
            this.btnTraspasar.Location = new System.Drawing.Point(380, 170);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(112, 23);
            this.btnTraspasar.TabIndex = 38;
            this.btnTraspasar.Text = "&Traspasar selección";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(380, 141);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSeleccinarCod
            // 
            this.btnSeleccinarCod.AutoSize = true;
            this.btnSeleccinarCod.Location = new System.Drawing.Point(380, 287);
            this.btnSeleccinarCod.Name = "btnSeleccinarCod";
            this.btnSeleccinarCod.Size = new System.Drawing.Size(126, 23);
            this.btnSeleccinarCod.TabIndex = 36;
            this.btnSeleccinarCod.Text = "&Seleccionar por código";
            this.btnSeleccinarCod.UseVisualStyleBackColor = true;
            this.btnSeleccinarCod.Click += new System.EventHandler(this.btnSeleccinarCod_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(132, 287);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 246);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(201, 20);
            this.txtValor.TabIndex = 33;
            // 
            // chkColumnas
            // 
            this.chkColumnas.AutoSize = true;
            this.chkColumnas.Location = new System.Drawing.Point(6, 168);
            this.chkColumnas.Name = "chkColumnas";
            this.chkColumnas.Size = new System.Drawing.Size(124, 17);
            this.chkColumnas.TabIndex = 32;
            this.chkColumnas.Text = "&Mostrar en columnas";
            this.chkColumnas.UseVisualStyleBackColor = true;
            this.chkColumnas.CheckedChanged += new System.EventHandler(this.chkColumnas_CheckedChanged);
            // 
            // chkOrdenar
            // 
            this.chkOrdenar.AutoSize = true;
            this.chkOrdenar.Location = new System.Drawing.Point(6, 145);
            this.chkOrdenar.Name = "chkOrdenar";
            this.chkOrdenar.Size = new System.Drawing.Size(64, 17);
            this.chkOrdenar.TabIndex = 31;
            this.chkOrdenar.Text = "&Ordenar";
            this.chkOrdenar.UseVisualStyleBackColor = true;
            this.chkOrdenar.CheckedChanged += new System.EventHandler(this.chkOrdenar_CheckedChanged);
            // 
            // rdoExtendida
            // 
            this.rdoExtendida.AutoSize = true;
            this.rdoExtendida.Location = new System.Drawing.Point(18, 65);
            this.rdoExtendida.Name = "rdoExtendida";
            this.rdoExtendida.Size = new System.Drawing.Size(72, 17);
            this.rdoExtendida.TabIndex = 2;
            this.rdoExtendida.TabStop = true;
            this.rdoExtendida.Text = "Extendida";
            this.rdoExtendida.UseVisualStyleBackColor = true;
            this.rdoExtendida.CheckedChanged += new System.EventHandler(this.rdoExtendida_CheckedChanged);
            // 
            // rdoMultiple
            // 
            this.rdoMultiple.AutoSize = true;
            this.rdoMultiple.Location = new System.Drawing.Point(18, 42);
            this.rdoMultiple.Name = "rdoMultiple";
            this.rdoMultiple.Size = new System.Drawing.Size(61, 17);
            this.rdoMultiple.TabIndex = 1;
            this.rdoMultiple.TabStop = true;
            this.rdoMultiple.Text = "Múltiple";
            this.rdoMultiple.UseVisualStyleBackColor = true;
            this.rdoMultiple.CheckedChanged += new System.EventHandler(this.rdoMultiple_CheckedChanged);
            // 
            // rdoUno
            // 
            this.rdoUno.AutoSize = true;
            this.rdoUno.Location = new System.Drawing.Point(18, 19);
            this.rdoUno.Name = "rdoUno";
            this.rdoUno.Size = new System.Drawing.Size(45, 17);
            this.rdoUno.TabIndex = 0;
            this.rdoUno.TabStop = true;
            this.rdoUno.Text = "Uno";
            this.rdoUno.UseVisualStyleBackColor = true;
            this.rdoUno.CheckedChanged += new System.EventHandler(this.rdoUno_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rdoExtendida);
            this.GroupBox1.Controls.Add(this.rdoMultiple);
            this.GroupBox1.Controls.Add(this.rdoUno);
            this.GroupBox1.Location = new System.Drawing.Point(205, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(113, 108);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Tipo de Selección";
            // 
            // lstValores
            // 
            this.lstValores.FormattingEnabled = true;
            this.lstValores.Items.AddRange(new object[] {
            "Programación I",
            "Laboratorio I",
            "Programación II",
            "Laboratorio II",
            "Programación III",
            "Laboratorio III"});
            this.lstValores.Location = new System.Drawing.Point(6, 12);
            this.lstValores.Name = "lstValores";
            this.lstValores.Size = new System.Drawing.Size(175, 108);
            this.lstValores.TabIndex = 30;
            this.lstValores.SelectedIndexChanged += new System.EventHandler(this.lstValores_SelectedIndexChanged);
            // 
            // lstTraspaso
            // 
            this.lstTraspaso.FormattingEnabled = true;
            this.lstTraspaso.Location = new System.Drawing.Point(345, 12);
            this.lstTraspaso.Name = "lstTraspaso";
            this.lstTraspaso.Size = new System.Drawing.Size(175, 108);
            this.lstTraspaso.TabIndex = 29;
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 323);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSeleccinarCod);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.chkColumnas);
            this.Controls.Add(this.chkOrdenar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lstValores);
            this.Controls.Add(this.lstTraspaso);
            this.Name = "FrmListBox";
            this.Text = "FrmListBox";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblIndice;
        internal System.Windows.Forms.Label lblElemento;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Button btnTraspasar;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnSeleccinarCod;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.CheckBox chkColumnas;
        internal System.Windows.Forms.CheckBox chkOrdenar;
        internal System.Windows.Forms.RadioButton rdoExtendida;
        internal System.Windows.Forms.RadioButton rdoMultiple;
        internal System.Windows.Forms.RadioButton rdoUno;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lstValores;
        internal System.Windows.Forms.ListBox lstTraspaso;
    }
}