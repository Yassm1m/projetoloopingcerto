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
    public partial class frmlooping : Form
    {
        public frmlooping()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txttab.Text);
            i = 1;
            while (i < 11)
            {
                result = tab * i;
                i++;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n ", result.ToString());
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txttab.Text);

            for (i = 1; i < 11; i++)
            {
                result = tab * 1;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n ", result.ToString());
            }



        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttab.Clear();
            txtresult.Clear();

            txttab.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txttab.Text);
            i = 1;

            do
            {
                result = tab * 1;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n ", result.ToString());
               i++;
            }while(i < 11);

        }
    }
}
