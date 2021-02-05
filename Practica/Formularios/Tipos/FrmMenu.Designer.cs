namespace Tipos
{
    partial class FrmMenu
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.TipoDeFormulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogoOModalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoDeFormulariosToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(451, 24);
            this.mnuMenu.TabIndex = 2;
            this.mnuMenu.Text = "MenuStrip1";
            // 
            // TipoDeFormulariosToolStripMenuItem
            // 
            this.TipoDeFormulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NormalToolStripMenuItem,
            this.ContenidoToolStripMenuItem,
            this.PropietarioToolStripMenuItem,
            this.DialogoOModalToolStripMenuItem});
            this.TipoDeFormulariosToolStripMenuItem.Name = "TipoDeFormulariosToolStripMenuItem";
            this.TipoDeFormulariosToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.TipoDeFormulariosToolStripMenuItem.Text = "Tipo de Formularios";
            // 
            // NormalToolStripMenuItem
            // 
            this.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem";
            this.NormalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NormalToolStripMenuItem.Text = "Normal";
            this.NormalToolStripMenuItem.Click += new System.EventHandler(this.NormalToolStripMenuItem_Click);
            // 
            // ContenidoToolStripMenuItem
            // 
            this.ContenidoToolStripMenuItem.Name = "ContenidoToolStripMenuItem";
            this.ContenidoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ContenidoToolStripMenuItem.Text = "Contenido";
            this.ContenidoToolStripMenuItem.Click += new System.EventHandler(this.ContenidoToolStripMenuItem_Click);
            // 
            // PropietarioToolStripMenuItem
            // 
            this.PropietarioToolStripMenuItem.Name = "PropietarioToolStripMenuItem";
            this.PropietarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.PropietarioToolStripMenuItem.Text = "Propietario";
            this.PropietarioToolStripMenuItem.Click += new System.EventHandler(this.PropietarioToolStripMenuItem_Click);
            // 
            // DialogoOModalToolStripMenuItem
            // 
            this.DialogoOModalToolStripMenuItem.Name = "DialogoOModalToolStripMenuItem";
            this.DialogoOModalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.DialogoOModalToolStripMenuItem.Text = "Dialogo o modal";
            this.DialogoOModalToolStripMenuItem.Click += new System.EventHandler(this.DialogoOModalToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 327);
            this.Controls.Add(this.mnuMenu);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip mnuMenu;
        internal System.Windows.Forms.ToolStripMenuItem TipoDeFormulariosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NormalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ContenidoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PropietarioToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DialogoOModalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
    }
}

