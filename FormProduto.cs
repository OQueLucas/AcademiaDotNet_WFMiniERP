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

        private void AtualizarFornecedor()
        {
            var list_of_companies = _contexto.Fornecedores;

            foreach (Fornecedor c in list_of_companies)
            {
                CBItem item = new CBItem();
                item.Name = c.RazaoSocial;
                item.Value = c.ID;
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
                Preco = double.Parse(textBox_Preco.Text),
                FornecedorID = (comboBox_Fornecedor.SelectedItem as CBItem).Value
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
            var produtos = await _produtoService.FindAllAsyncTeste();
            dataGridView_Produtos.DataSource = produtos;
        }
    }
}
