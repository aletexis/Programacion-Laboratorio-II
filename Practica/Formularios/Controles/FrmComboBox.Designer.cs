namespace Controles
{
    partial class FrmComboBox
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboSimple = new System.Windows.Forms.ComboBox();
            this.lblSimple = new System.Windows.Forms.Label();
            this.cboDropDownList = new System.Windows.Forms.ComboBox();
            this.lblDropDownList = new System.Windows.Forms.Label();
            this.cboDropDown = new System.Windows.Forms.ComboBox();
            this.lblDropDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(200, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboSimple
            // 
            this.cboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboSimple.FormattingEnabled = true;
            this.cboSimple.Location = new System.Drawing.Point(329, 34);
            this.cboSimple.MaxDropDownItems = 5;
            this.cboSimple.Name = "cboSimple";
            this.cboSimple.Size = new System.Drawing.Size(121, 72);
            this.cboSimple.TabIndex = 19;
            // 
            // lblSimple
            // 
            this.lblSimple.AutoSize = true;
            this.lblSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimple.Location = new System.Drawing.Point(351, 18);
            this.lblSimple.Name = "lblSimple";
            this.lblSimple.Size = new System.Drawing.Size(66, 13);
            this.lblSimple.TabIndex = 18;
            this.lblSimple.Text = "Estilo Simple";
            // 
            // cboDropDownList
            // 
            this.cboDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropDownList.FormattingEnabled = true;
            this.cboDropDownList.Location = new System.Drawing.Point(176, 34);
            this.cboDropDownList.Name = "cboDropDownList";
            this.cboDropDownList.Size = new System.Drawing.Size(121, 21);
            this.cboDropDownList.TabIndex = 17;
            // 
            // lblDropDownList
            // 
            this.lblDropDownList.AutoSize = true;
            this.lblDropDownList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropDownList.Location = new System.Drawing.Point(184, 18);
            this.lblDropDownList.Name = "lblDropDownList";
            this.lblDropDownList.Size = new System.Drawing.Size(102, 13);
            this.lblDropDownList.TabIndex = 16;
            this.lblDropDownList.Text = "Estilo DropDownList";
            // 
            // cboDropDown
            // 
            this.cboDropDown.FormattingEnabled = true;
            this.cboDropDown.Location = new System.Drawing.Point(17, 34);
            this.cboDropDown.Name = "cboDropDown";
            this.cboDropDown.Size = new System.Drawing.Size(121, 21);
            this.cboDropDown.TabIndex = 15;
            // 
            // lblDropDown
            // 
            this.lblDropDown.AutoSize = true;
            this.lblDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropDown.Location = new System.Drawing.Point(31, 18);
            this.lblDropDown.Name = "lblDropDown";
            this.lblDropDown.Size = new System.Drawing.Size(86, 13);
            this.lblDropDown.TabIndex = 14;
            this.lblDropDown.Text = "Estilo DropDown";
            // 
            // FrmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 184);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboSimple);
            this.Controls.Add(this.lblSimple);
            this.Controls.Add(this.cboDropDownList);
            this.Controls.Add(this.lblDropDownList);
            this.Controls.Add(this.cboDropDown);
            this.Controls.Add(this.lblDropDown);
            this.Name = "FrmComboBox";
            this.Text = "FrmComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.ComboBox cboSimple;
        internal System.Windows.Forms.Label lblSimple;
        internal System.Windows.Forms.ComboBox cboDropDownList;
        internal System.Windows.Forms.Label lblDropDownList;
        internal System.Windows.Forms.ComboBox cboDropDown;
        internal System.Windows.Forms.Label lblDropDown;
    }
}