namespace Controles
{
    partial class FrmCheckBox
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
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.lblMuestra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrar.Checked = true;
            this.chkMostrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMostrar.Location = new System.Drawing.Point(160, 140);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(101, 17);
            this.chkMostrar.TabIndex = 5;
            this.chkMostrar.Text = "Mostrar Cadena";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            // 
            // chkColor
            // 
            this.chkColor.AutoSize = true;
            this.chkColor.Location = new System.Drawing.Point(160, 71);
            this.chkColor.Name = "chkColor";
            this.chkColor.Size = new System.Drawing.Size(91, 17);
            this.chkColor.TabIndex = 4;
            this.chkColor.Text = "Cambiar Color";
            this.chkColor.UseVisualStyleBackColor = true;
            this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
            // 
            // lblMuestra
            // 
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMuestra.Location = new System.Drawing.Point(12, 192);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(0, 18);
            this.lblMuestra.TabIndex = 6;
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.lblMuestra);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.chkColor);
            this.Name = "FrmCheckBox";
            this.Text = "FrmCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkMostrar;
        internal System.Windows.Forms.CheckBox chkColor;
        internal System.Windows.Forms.Label lblMuestra;
    }
}