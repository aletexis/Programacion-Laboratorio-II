namespace Controles
{
    partial class FrmRadioButton
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtComic = new System.Windows.Forms.RadioButton();
            this.rbtGaramond = new System.Windows.Forms.RadioButton();
            this.rbtTahoma = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtRojo = new System.Windows.Forms.RadioButton();
            this.rbtAmarillo = new System.Windows.Forms.RadioButton();
            this.rbtVerde = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.Text = "Probando Controles de Opción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtComic);
            this.panel1.Controls.Add(this.rbtGaramond);
            this.panel1.Controls.Add(this.rbtTahoma);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 100);
            this.panel1.TabIndex = 21;
            // 
            // rbtComic
            // 
            this.rbtComic.AutoSize = true;
            this.rbtComic.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtComic.Location = new System.Drawing.Point(19, 62);
            this.rbtComic.Name = "rbtComic";
            this.rbtComic.Size = new System.Drawing.Size(61, 22);
            this.rbtComic.TabIndex = 19;
            this.rbtComic.TabStop = true;
            this.rbtComic.Text = "Comic";
            this.rbtComic.UseVisualStyleBackColor = true;
            this.rbtComic.CheckedChanged += new System.EventHandler(this.rbtComic_CheckedChanged);
            // 
            // rbtGaramond
            // 
            this.rbtGaramond.AutoSize = true;
            this.rbtGaramond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGaramond.Location = new System.Drawing.Point(19, 39);
            this.rbtGaramond.Name = "rbtGaramond";
            this.rbtGaramond.Size = new System.Drawing.Size(90, 20);
            this.rbtGaramond.TabIndex = 18;
            this.rbtGaramond.TabStop = true;
            this.rbtGaramond.Text = "Garamond";
            this.rbtGaramond.UseVisualStyleBackColor = true;
            this.rbtGaramond.CheckedChanged += new System.EventHandler(this.rbtGaramond_CheckedChanged);
            // 
            // rbtTahoma
            // 
            this.rbtTahoma.AutoSize = true;
            this.rbtTahoma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTahoma.Location = new System.Drawing.Point(19, 16);
            this.rbtTahoma.Name = "rbtTahoma";
            this.rbtTahoma.Size = new System.Drawing.Size(73, 20);
            this.rbtTahoma.TabIndex = 17;
            this.rbtTahoma.TabStop = true;
            this.rbtTahoma.Text = "Tahoma";
            this.rbtTahoma.UseVisualStyleBackColor = true;
            this.rbtTahoma.CheckedChanged += new System.EventHandler(this.rbtTahoma_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtRojo);
            this.panel2.Controls.Add(this.rbtAmarillo);
            this.panel2.Controls.Add(this.rbtVerde);
            this.panel2.Location = new System.Drawing.Point(164, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 100);
            this.panel2.TabIndex = 22;
            // 
            // rbtRojo
            // 
            this.rbtRojo.AutoSize = true;
            this.rbtRojo.BackColor = System.Drawing.Color.Red;
            this.rbtRojo.Location = new System.Drawing.Point(34, 65);
            this.rbtRojo.Name = "rbtRojo";
            this.rbtRojo.Size = new System.Drawing.Size(47, 17);
            this.rbtRojo.TabIndex = 22;
            this.rbtRojo.TabStop = true;
            this.rbtRojo.Text = "Rojo";
            this.rbtRojo.UseVisualStyleBackColor = false;
            this.rbtRojo.CheckedChanged += new System.EventHandler(this.rbtRojo_CheckedChanged);
            // 
            // rbtAmarillo
            // 
            this.rbtAmarillo.AutoSize = true;
            this.rbtAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.rbtAmarillo.Location = new System.Drawing.Point(34, 42);
            this.rbtAmarillo.Name = "rbtAmarillo";
            this.rbtAmarillo.Size = new System.Drawing.Size(61, 17);
            this.rbtAmarillo.TabIndex = 21;
            this.rbtAmarillo.TabStop = true;
            this.rbtAmarillo.Text = "Amarillo";
            this.rbtAmarillo.UseVisualStyleBackColor = false;
            this.rbtAmarillo.CheckedChanged += new System.EventHandler(this.rbtAmarillo_CheckedChanged);
            // 
            // rbtVerde
            // 
            this.rbtVerde.AutoSize = true;
            this.rbtVerde.BackColor = System.Drawing.Color.Green;
            this.rbtVerde.Location = new System.Drawing.Point(34, 19);
            this.rbtVerde.Name = "rbtVerde";
            this.rbtVerde.Size = new System.Drawing.Size(53, 17);
            this.rbtVerde.TabIndex = 20;
            this.rbtVerde.TabStop = true;
            this.rbtVerde.Text = "Verde";
            this.rbtVerde.UseVisualStyleBackColor = false;
            this.rbtVerde.CheckedChanged += new System.EventHandler(this.rbtVerde_CheckedChanged);
            // 
            // FrmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 209);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmRadioButton";
            this.Text = "FrmRadioButton";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RadioButton rbtComic;
        internal System.Windows.Forms.RadioButton rbtGaramond;
        internal System.Windows.Forms.RadioButton rbtTahoma;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.RadioButton rbtRojo;
        internal System.Windows.Forms.RadioButton rbtAmarillo;
        internal System.Windows.Forms.RadioButton rbtVerde;
    }
}