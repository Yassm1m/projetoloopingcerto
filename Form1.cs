using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLooping
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void loOPINGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void looping1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void projeto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlooping loop = new frmlooping();
            loop.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projeto1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmposto fm = new frmposto();
            fm.Show();
              
        }
    }
}
