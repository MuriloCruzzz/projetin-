using projeto2023.models;
using projeto2023.views.colaboradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.movimentacoes
{
    public partial class consulta_transacoes : Form
    {
        public consulta_transacoes()
        {
            InitializeComponent();
        }

        private void dtv_transacoes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_transacoes.Rows[e.RowIndex];

                // Preencha os TextBox com os valores da linha selecionada
                cmb_categoria.Text = row.Cells["CategoriaId"].Value.ToString();
                cmb_centroCusto.Text = row.Cells["CentroDeCustoId"].Value.ToString();
                cmb_conta.Text = row.Cells["ContaBancariaId"].Value.ToString();
                txb_valor.Text = row.Cells["Valor"].Value.ToString();
                txb_descricao.Text = row.Cells["Descricao"].Value.ToString();
                

                //button_excluir.Visible = true;
                //btn_salvar.Visible = true;
                if (checkbox_status.Checked)
                {
                    btn_ativar.Visible = true;
                    button_excluir.Visible = false;
                    btn_salvar.Visible = false;
                }
                else
                {
                    button_excluir.Visible = true;
                    btn_salvar.Visible = true;
                    btn_ativar.Visible = false;
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            /*var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_movimentacoes((dt)))
            {
                frm.ShowDialog();
            }*/
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_valor.Clear();
            cmb_categoria.SelectedIndex = -1;
            cmb_conta.SelectedIndex = -1;
            cmb_centroCusto.SelectedIndex = -1;
            txb_descricao.Clear();
            checked_receita.Checked = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores inseridos pelo usuário, incluindo se é receita ou despesa
            DateTime dataMovimentacao = new DateTime(2007, 1, 21);
            dataMovimentacao = mnth_dataMov.SelectionStart;
            decimal valorMovimentacao = decimal.Parse(txb_valor.Text);
            int categoriaId = (int)cmb_categoria.SelectedValue;
            int contaBancariaId = (int)cmb_conta.SelectedValue;
            int centroDeCustoId = (int)cmb_centroCusto.SelectedValue; // Campo para selecionar o centro de custo
            string descricao = txb_descricao.Text;
            bool isReceita = checked_receita.Checked; // Verifica se é uma receita

            // Verifique se é uma receita ou despesa e crie a transação correspondente
            if (isReceita)
            {
                Receita novaReceita = new Receita
                {
                    Data = dataMovimentacao,
                    Valor = valorMovimentacao,
                    CategoriaId = categoriaId,
                    ContaBancariaId = contaBancariaId,
                    CentroDeCustoId = centroDeCustoId,
                    Descricao = descricao
                };
                // Salve a nova receita no banco de dados ou em uma lista, dependendo da sua implementação
                // ...
            }
            else
            {
                Despesas novaDespesa = new Despesas
                {
                    Data = dataMovimentacao,
                    Valor = valorMovimentacao,
                    CategoriaId = categoriaId,
                    ContaBancariaId = contaBancariaId,
                    CentroDeCustoId = centroDeCustoId,
                    Descricao = descricao
                };
                // Salve a nova despesa no banco de dados ou em uma lista, dependendo da sua implementação
                // ...
            }
        }
    }
}
