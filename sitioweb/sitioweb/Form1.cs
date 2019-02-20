using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitioweb
{
    public partial class Luminity : Form
    {
        public Luminity()
        {
            InitializeComponent();
        }
        favorito favorito = new favorito();
        Historial h = new Historial();
        String url_text = "https://www.google.com/";      
        WebBrowser web = new WebBrowser();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            web = new WebBrowser();
            web.Navigate(url_text);
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Nueva Pestaña");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;

          
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void irToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
            if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
            {
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
                h.listb.Items.Add(toolStripComboBox1.Text);
            }

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Nueva Pestaña");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        private void cerrarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
                if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
                {
                    toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
                    h.listb.Items.Add(toolStripComboBox1.Text);
                }
            }
        }

        private void rToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h = new Historial();
            h.Show();
            
        }

        private void agregarAFavoritoToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            favorito.listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void pestañasFavoritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            favorito = new favorito();
            favorito.Show();
        }

        private void agregarAFavoritoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            favorito.listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}
