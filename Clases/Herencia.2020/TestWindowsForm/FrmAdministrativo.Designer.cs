namespace HerenciaWindowsForm
{
    partial class FrmAdministrativo
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboSimpatia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simpatía";
            // 
            // cboSimpatia
            // 
            this.cboSimpatia.FormattingEnabled = true;
            this.cboSimpatia.Location = new System.Drawing.Point(50, 207);
            this.cboSimpatia.Name = "cboSimpatia";
            this.cboSimpatia.Size = new System.Drawing.Size(156, 21);
            this.cboSimpatia.TabIndex = 11;
            // 
            // FrmAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 290);
            this.Controls.Add(this.cboSimpatia);
            this.Controls.Add(this.label3);
            this.Name = "FrmAdministrativo";
            this.Text = "FrmAdministrativo";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cboSimpatia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSimpatia;
    }
}