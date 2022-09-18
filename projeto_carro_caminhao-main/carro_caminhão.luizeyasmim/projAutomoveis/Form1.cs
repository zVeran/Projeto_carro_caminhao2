using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btncaminhao_Click(object sender, EventArgs e)
        {
            frmcaminhao caminhao = new frmcaminhao();
            this.Hide();
            caminhao.Show();

        }

        private void btncarro_Click(object sender, EventArgs e)
        {
            frmcarro carro = new frmcarro();
            this.Hide();
            carro.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
