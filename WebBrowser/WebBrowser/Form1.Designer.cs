namespace WebBrowser
{
    partial class LuminityBrowser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.direccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.irToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.direccionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rToolStripMenuItem,
            this.toolStripComboBox1,
            this.irToolStripMenuItem,
            this.nuevaPestañaToolStripMenuItem,
            this.cerrarPestañaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // direccionToolStripMenuItem
            // 
            this.direccionToolStripMenuItem.Image = global::WebBrowser.Properties.Resources.back;
            this.direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            this.direccionToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.direccionToolStripMenuItem.Click += new System.EventHandler(this.direccionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WebBrowser.Properties.Resources.fowards;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Image = global::WebBrowser.Properties.Resources.reload1;
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(350, 23);
            // 
            // irToolStripMenuItem
            // 
            this.irToolStripMenuItem.Image = global::WebBrowser.Properties.Resources.navigate1;
            this.irToolStripMenuItem.Name = "irToolStripMenuItem";
            this.irToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.irToolStripMenuItem.Text = "Ir";
            this.irToolStripMenuItem.Click += new System.EventHandler(this.irToolStripMenuItem_Click);
            // 
            // nuevaPestañaToolStripMenuItem
            // 
            this.nuevaPestañaToolStripMenuItem.Image = global::WebBrowser.Properties.Resources.agregar;
            this.nuevaPestañaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaPestañaToolStripMenuItem.Name = "nuevaPestañaToolStripMenuItem";
            this.nuevaPestañaToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.nuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña";
            // 
            // cerrarPestañaToolStripMenuItem
            // 
            this.cerrarPestañaToolStripMenuItem.Image = global::WebBrowser.Properties.Resources.cerrar;
            this.cerrarPestañaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarPestañaToolStripMenuItem.Name = "cerrarPestañaToolStripMenuItem";
            this.cerrarPestañaToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.cerrarPestañaToolStripMenuItem.Text = "Cerrar Pestaña";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 465);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // LuminityBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LuminityBrowser";
            this.Text = "Luminity Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem direccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem irToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarPestañaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

