using projeto2023.views.fornecedores;
using projeto2023.views.movimentacoes;
using projeto2023.views.movimentacoes.categorias;
using projeto2023.views.movimentacoes.contas;
using projeto2023.views.movimentacoes.estoque;
using projeto2023.views.movimentacoes.sangria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.frms
{
    public partial class movimentacoes : Form
    {
        public movimentacoes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_contas_Click(object sender, EventArgs e)
        {
            crud_conta frm = new crud_conta();
            frm.ShowDialog();
        }

        private void btn_Transacoes_Click(object sender, EventArgs e)
        {
            crud_transacoes frm = new crud_transacoes();
            frm.ShowDialog();
        }

        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            crud_categoria frm = new crud_categoria();
            frm.ShowDialog();
        }

        private void btn_SangriaCaixa_Click(object sender, EventArgs e)
        {
            crud_sangria frm = new crud_sangria();
            frm.ShowDialog();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            crud_estoque frm = new crud_estoque();
            frm.ShowDialog();
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fechamento_Click(object sender, EventArgs e)
        {

        }
    }
}
