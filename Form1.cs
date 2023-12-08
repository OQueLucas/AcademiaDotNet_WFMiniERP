using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.DataModels.Enum;
using AcademiaDotNet_WFMiniERP.Services;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class Form1 : Form
    {
        private readonly ProdutoService _produtoService = new();
        private readonly ClienteService _clienteService = new();
        private readonly NotaService _notaService = new();
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            AtualizarProdutos();
            AtualizarClientes();
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new();
            formCliente.ShowDialog();
        }

        private void button_Fornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new();
            formFornecedor.ShowDialog();
        }

        private void button_Produtos_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new();
            formProduto.ShowDialog();
        }

        private void button_Notas_Click(object sender, EventArgs e)
        {
            FormNotaFiscal formNotaFiscal = new();
            formNotaFiscal.ShowDialog();
        }

        private async void AtualizarProdutos()
        {
            comboBox_Produtos.Items.Clear();
            comboBox_Produtos.Items.Insert(0, "Selecione um produto: ");
            comboBox_Produtos.SelectedIndex = 0;

            var produtos = await _produtoService.FindAllAsync();

            foreach (Produto produto in produtos)
            {
                CBItem item = new()
                {
                    ID = produto.ID,
                    Name = $"({produto.ID}) {produto.Nome}"
                };
                comboBox_Produtos.Items.Add(item);
            }
        }

        private async void AtualizarClientes()
        {
            comboBox_Clientes.Items.Clear();
            comboBox_Clientes.Items.Insert(0, "Selecione um cliente: ");
            comboBox_Clientes.SelectedIndex = 0;

            var clientes = await _clienteService.FindAllAsync();

            foreach (Cliente cliente in clientes)
            {
                CBItem item = new()
                {
                    ID = cliente.ID,
                    Name = cliente.Nome
                };
                comboBox_Clientes.Items.Add(item);
            }
        }

        private async void button_Adicionar_Click(object sender, EventArgs e)
        {
            CBItem? itemSelecionado = comboBox_Produtos.SelectedItem as CBItem;

            if (itemSelecionado == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            int produtoID = itemSelecionado.ID;

            Produto produto = await _produtoService.FindByIDAsync(produtoID);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado");
                return;
            }

            ItemNota item = new()
            {
                Nome = produto.Nome,
                Preco = produto.Preco,
                Quantidade = int.Parse(numericUpDown_Quantidade.Value.ToString()),
                ProdutoID = produtoID
            };

            dataGridView_Itens.Rows.Add(new string[] { dataGridView_Itens.RowCount.ToString(), item.ProdutoID.ToString(), item.Nome, item.Preco.ToString(), item.Quantidade.ToString(), item.ValorTotal.ToString() });
        }

        private async void button_EmitirNota_Click(object sender, EventArgs e)
        {
            if (dataGridView_Itens.RowCount == 0)
            {
                MessageBox.Show("Nenhum item foi adicionado!");
                return;
            }

            CBItem? itemSelecionado = comboBox_Clientes.SelectedItem as CBItem;

            if (itemSelecionado == null)
            {
                MessageBox.Show("Selecione o cliente!");
                return;
            }

            int clienteID = itemSelecionado.ID;

            Cliente cliente = await _clienteService.FindByIDAsync(clienteID);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado!");
                return;
            }

            List<ItemNota> listItensNotas = new();

            Nota nota = new()
            {
                DataEmissao = DateTime.Now,
                itens = listItensNotas,
                ClienteID = clienteID,
                Status = StatusNota.Emitida
            };

            for (int i = 0; i < dataGridView_Itens.RowCount; i++)
            {
                ItemNota item = new()
                {
                    Nome = dataGridView_Itens.Rows[i].Cells["Column_Nome"].Value.ToString(),
                    Preco = decimal.Parse(dataGridView_Itens.Rows[i].Cells["Column_Preco"].Value.ToString()),
                    Quantidade = int.Parse(dataGridView_Itens.Rows[i].Cells["Column_Quantidade"].Value.ToString()),
                    ProdutoID = int.Parse(dataGridView_Itens.Rows[i].Cells["Column_ProdutoID"].Value.ToString()),
                    Nota = nota
                };

                listItensNotas.Add(item);
            }

            try
            {
                bool adicionado = await _notaService.InsertAsync(nota);
                if (adicionado)
                {
                    MessageBox.Show("Nota emitida com sucesso!");

                    Nota novaNota = await _notaService.FindByIDAsync(nota.ID);
                    nota.Cliente = await _clienteService.FindByIDAsync(nota.ClienteID);
                    novaNota.GerarPDF();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void button_AtualizarClientes_Click(object sender, EventArgs e)
        {
            AtualizarProdutos();
            AtualizarClientes();
        }
    }
}
