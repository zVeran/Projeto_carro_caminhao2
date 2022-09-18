using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmcarro : Form
    {

        Carro carro;
        public frmcarro()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Clear();
            txtBagagem.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            

            carro = new Carro(txtModel.Text, txtPlaca.Text, txtCor.Text, txtTpCarro.Text,(Convert.ToInt32(txtAno.Text)),
            (Convert.ToDouble(txtBagagem.Text)), (Convert.ToInt32(txtNumPorta.Text)), txtChassi.Text);

            txtAno.Clear();
            txtBagagem.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();

            MessageBox.Show("Carro cadastrado com sucesso.");

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.MostrarDados());
        }
    }
}
