using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.Services;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormProduto : Form
    {
        private readonly ProdutoService _produtoService = new();
        private readonly Contexto _contexto = new();
        public FormProduto()
        {
            InitializeComponent();
            CenterToParent();
            BuscaProdutos();
            AtualizarFornecedor();
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBox_Nome.Text = String.Empty;
            textBox_Preco.Text = String.Empty;
            numericUpDown_QuantidadeEstoque.Text = String.Empty;
            comboBox_Fornecedor.SelectedIndex = 0;
        }

        private void textBox_Preco_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_Preco.Text))
                    return;

                textBox_Preco.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(textBox_Preco.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void dataGridView_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_Produtos.Columns["Column_Excluir"].Index && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView_Produtos.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
                Excluir(id);
            }
        }

        private async Task<bool> Excluir(int id)
        {
            bool excluido = await _produtoService.RemoveAsync(id);
            if (excluido)
            {
                BuscaProdutos();
                MessageBox.Show("Excluído com sucesso!");
                return true;
            }
            return false;
        }

        private void AtualizarFornecedor()
        {
            var fornecedores = _contexto.Fornecedores;

            foreach (Fornecedor fornecedor in fornecedores)
            {
                CBItem item = new()
                {
                    ID = fornecedor.ID,
                    Name = fornecedor.RazaoSocial
                };
                comboBox_Fornecedor.Items.Add(item);
            }
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private async Task Cadastrar()
        {
            Produto produto = new()
            {
                Nome = textBox_Nome.Text,
                Preco = decimal.Parse(textBox_Preco.Text),
                FornecedorID = (comboBox_Fornecedor.SelectedItem as CBItem).ID
            };

            bool adicionado = await _produtoService.InsertAsync(produto);

            if (adicionado)
            {
                LimparCampos();
                BuscaProdutos();
                MessageBox.Show("Produto inserido com sucesso!");
            }
        }

        private async Task BuscaProdutos()
        {
            dataGridView_Produtos.Rows.Clear();

            var produtos = await _produtoService.FindAllAsyncQuery();
            dataGridView_Produtos.AutoGenerateColumns = false;

            foreach (Produto produto in produtos)
            {
                dataGridView_Produtos.Rows.Add(new string[] { produto.ID.ToString(), produto.Nome, produto.Preco.ToString(), produto.Fornecedor.RazaoSocial, produto.Fornecedor.ID.ToString() });
            }
        }

        private async void dataGridView_Produtos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView_Produtos.CurrentRow.Index;
            bool linhaAtualizada = false;

            Produto produtoAtualizado = new()
            {
                ID = int.Parse(dataGridView_Produtos.Rows[linha].Cells["Column_ID"].Value.ToString()),
                Nome = dataGridView_Produtos.Rows[linha].Cells["Column_Nome"].EditedFormattedValue.ToString(),
                Preco = decimal.Parse(dataGridView_Produtos.Rows[linha].Cells["Column_Preco"].EditedFormattedValue.ToString()),
                FornecedorID = int.Parse(dataGridView_Produtos.Rows[linha].Cells["Column_FornecedorID"].Value.ToString()),
            };

            foreach(DataGridViewColumn item in dataGridView_Produtos.Columns)
            {
                if (dataGridView_Produtos.Rows[linha].Cells[item.Index].Value != dataGridView_Produtos.Rows[linha].Cells[item.Index].EditedFormattedValue)
                {
                    linhaAtualizada = true;
                    break;
                }
            }

            if (!linhaAtualizada)
                return;

            bool atualizado = await _produtoService.UpdateAsync(produtoAtualizado);

            if (atualizado)
            {
                MessageBox.Show("Produto atualizado!");
            }
        }
    }
}
