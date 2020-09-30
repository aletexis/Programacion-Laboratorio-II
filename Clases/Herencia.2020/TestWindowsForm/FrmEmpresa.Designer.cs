namespace HerenciaWindowsForm
{
    partial class FrmEmpresa
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
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCadete = new System.Windows.Forms.Button();
            this.btnAgregarProg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarAdmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVisor
            // 
            this.lstVisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(6, 34);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(493, 186);
            this.lstVisor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAgregarCadete);
            this.groupBox1.Controls.Add(this.btnAgregarProg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboOrdenamiento);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregarAdmin);
            this.groupBox1.Controls.Add(this.lstVisor);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btnAgregarCadete
            // 
            this.btnAgregarCadete.Location = new System.Drawing.Point(257, 255);
            this.btnAgregarCadete.Name = "btnAgregarCadete";
            this.btnAgregarCadete.Size = new System.Drawing.Size(69, 23);
            this.btnAgregarCadete.TabIndex = 6;
            this.btnAgregarCadete.Text = "+ Cadete";
            this.btnAgregarCadete.UseVisualStyleBackColor = true;
            this.btnAgregarCadete.Click += new System.EventHandler(this.btnAgregarCadete_Click);
            // 
            // btnAgregarProg
            // 
            this.btnAgregarProg.Location = new System.Drawing.Point(332, 226);
            this.btnAgregarProg.Name = "btnAgregarProg";
            this.btnAgregarProg.Size = new System.Drawing.Size(69, 52);
            this.btnAgregarProg.TabIndex = 7;
            this.btnAgregarProg.Text = "+ Prog";
            this.btnAgregarProg.UseVisualStyleBackColor = true;
            this.btnAgregarProg.Click += new System.EventHandler(this.btnAgregarProg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ordenamiento";
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Items.AddRange(new object[] {
            "Legajo ASC",
            "Legajo DESC",
            "Apellido ASC",
            "Apellido DESC",
            "Sueldo ASC",
            "Sueldo DESC"});
            this.cboOrdenamiento.Location = new System.Drawing.Point(6, 251);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(206, 21);
            this.cboOrdenamiento.TabIndex = 9;
            this.cboOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cboOrdenamiento_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 234);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 42);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarAdmin
            // 
            this.btnAgregarAdmin.Location = new System.Drawing.Point(257, 226);
            this.btnAgregarAdmin.Name = "btnAgregarAdmin";
            this.btnAgregarAdmin.Size = new System.Drawing.Size(69, 23);
            this.btnAgregarAdmin.TabIndex = 5;
            this.btnAgregarAdmin.Text = "+ Admin";
            this.btnAgregarAdmin.UseVisualStyleBackColor = true;
            this.btnAgregarAdmin.Click += new System.EventHandler(this.btnAgregarAdmin_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmpresa";
            this.Text = "FrmEmpresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarAdmin;
        private System.Windows.Forms.Button btnAgregarCadete;
        private System.Windows.Forms.Button btnAgregarProg;
    }
}