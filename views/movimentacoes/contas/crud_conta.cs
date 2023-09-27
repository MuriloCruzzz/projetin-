using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2023.models;

namespace projeto2023.views.movimentacoes.contas
{
    public partial class crud_conta : Form
    {
        public crud_conta()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores inseridos pelo usuário
            string nomeConta = txb_descricaoConta.Text;
            decimal saldoInicial = decimal.Parse(txb_saldoInicial.Text);

            // Crie uma nova instância da classe ContaBancaria
            Contas novaConta = new Contas
            {
                Nome = nomeConta,
                Saldo = saldoInicial
            };

            // Salve a nova conta no banco de dados ou em uma lista, dependendo da sua implementação
            // ...

            // Feche o formulário após salvar a conta
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
