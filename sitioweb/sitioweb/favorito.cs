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
    public partial class favorito : Form
    {
        public favorito()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {           
            listBox2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Text = "";
        }

        private void favorito_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
