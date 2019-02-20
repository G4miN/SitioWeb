namespace sitioweb
{
    partial class Luminity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luminity));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.irToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAFavoritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pestañasFavoritasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rToolStripMenuItem1,
            this.toolStripComboBox1,
            this.irToolStripMenuItem,
            this.nuevaPestañaToolStripMenuItem,
            this.cerrarPestañaToolStripMenuItem,
            this.agregarAFavoritoToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.pestañasFavoritasToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Image = global::sitioweb.Properties.Resources.back;
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            resources.ApplyResources(this.rToolStripMenuItem, "rToolStripMenuItem");
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::sitioweb.Properties.Resources.fowards;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rToolStripMenuItem1
            // 
            this.rToolStripMenuItem1.Image = global::sitioweb.Properties.Resources.reload;
            this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            resources.ApplyResources(this.rToolStripMenuItem1, "rToolStripMenuItem1");
            this.rToolStripMenuItem1.Click += new System.EventHandler(this.rToolStripMenuItem1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.Color.White;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox1_KeyDown);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // irToolStripMenuItem
            // 
            this.irToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.irToolStripMenuItem.Image = global::sitioweb.Properties.Resources.navigate;
            resources.ApplyResources(this.irToolStripMenuItem, "irToolStripMenuItem");
            this.irToolStripMenuItem.Name = "irToolStripMenuItem";
            this.irToolStripMenuItem.Click += new System.EventHandler(this.irToolStripMenuItem_Click);
            // 
            // nuevaPestañaToolStripMenuItem
            // 
            this.nuevaPestañaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevaPestañaToolStripMenuItem.Image = global::sitioweb.Properties.Resources.agregar;
            resources.ApplyResources(this.nuevaPestañaToolStripMenuItem, "nuevaPestañaToolStripMenuItem");
            this.nuevaPestañaToolStripMenuItem.Name = "nuevaPestañaToolStripMenuItem";
            this.nuevaPestañaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPestañaToolStripMenuItem_Click);
            // 
            // cerrarPestañaToolStripMenuItem
            // 
            this.cerrarPestañaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.cerrarPestañaToolStripMenuItem.Image = global::sitioweb.Properties.Resources.cerrar;
            resources.ApplyResources(this.cerrarPestañaToolStripMenuItem, "cerrarPestañaToolStripMenuItem");
            this.cerrarPestañaToolStripMenuItem.Name = "cerrarPestañaToolStripMenuItem";
            this.cerrarPestañaToolStripMenuItem.Click += new System.EventHandler(this.cerrarPestañaToolStripMenuItem_Click);
            // 
            // agregarAFavoritoToolStripMenuItem
            // 
            this.agregarAFavoritoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarAFavoritoToolStripMenuItem.Image = global::sitioweb.Properties.Resources.star;
            resources.ApplyResources(this.agregarAFavoritoToolStripMenuItem, "agregarAFavoritoToolStripMenuItem");
            this.agregarAFavoritoToolStripMenuItem.Name = "agregarAFavoritoToolStripMenuItem";
            this.agregarAFavoritoToolStripMenuItem.Click += new System.EventHandler(this.agregarAFavoritoToolStripMenuItem_Click_1);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.historialToolStripMenuItem.Image = global::sitioweb.Properties.Resources.history;
            resources.ApplyResources(this.historialToolStripMenuItem, "historialToolStripMenuItem");
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // pestañasFavoritasToolStripMenuItem
            // 
            this.pestañasFavoritasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pestañasFavoritasToolStripMenuItem.Image = global::sitioweb.Properties.Resources.fav;
            resources.ApplyResources(this.pestañasFavoritasToolStripMenuItem, "pestañasFavoritasToolStripMenuItem");
            this.pestañasFavoritasToolStripMenuItem.Name = "pestañasFavoritasToolStripMenuItem";
            this.pestañasFavoritasToolStripMenuItem.Click += new System.EventHandler(this.pestañasFavoritasToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Luminity
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Luminity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem pestañasFavoritasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agregarAFavoritoToolStripMenuItem;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        public System.Windows.Forms.ToolStripMenuItem irToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevaPestañaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cerrarPestañaToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
    }
}

