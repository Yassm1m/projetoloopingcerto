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
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double posto, litro, result;

            litro = Convert.ToDouble(txtlitro.Text);
            posto = Convert.ToChar(txtposto.Text);

            if (posto== 'A')
            {
                if (litro == 20)
                {
                   result = litro * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = result.ToString();
                }
                else
                {
                   result = litro * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = result.ToString();
                }
            }
            else if (posto == 'G')
            {
                if (posto <= 20)
                {
                    result = litro * (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = result.ToString();
                }
                else
                {
                    result = litro * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = result.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtposto.Clear();
            txtlitro.Clear();
            txtresult.Clear();

            txtposto.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}

