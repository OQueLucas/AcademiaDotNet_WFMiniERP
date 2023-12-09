using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.Services;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormCliente : Form
    {
        private readonly ClienteService _clienteService = new();

        public FormCliente()
        {
            InitializeComponent();
            CenterToParent();

            BuscaClientes();
        }

        private async void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_Clientes.Columns["Column_Excluir"].Index && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
                Excluir(id);
            }
        }

        private void maskedTextBox_CPF_Enter(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox textBox)
            {
                MaskFormat oldFormat = textBox.TextMaskFormat;
                textBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                string fullText = textBox.Text;
                textBox.TextMaskFormat = oldFormat;

                int index = fullText.IndexOf(textBox.PromptChar);
                if (index > -1)
                {
                    BeginInvoke(new Action(() => textBox.Select(index, 0)));
                }
            }
        }

        private async Task Cadastrar()
        {
            try
            {
                Cliente cliente = new()
                {
                    CPF = maskedTextBox_CPF.Text,
                    Nome = textBox_Nome.Text,
                    Email = textBox_Email.Text
                };

                bool adicionado = await _clienteService.InsertAsync(cliente);
                if (adicionado)
                {
                    LimparCampos();
                    BuscaClientes();
                    MessageBox.Show("Cliente inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private async Task BuscaClientes()
        {
            dataGridView_Clientes.Rows.Clear();

            var clientes = await _clienteService.FindAllAsync();

            foreach (var cliente in clientes)
            {
                dataGridView_Clientes.Rows.Add(new string[] { cliente.ID.ToString(), cliente.CPF, cliente.Nome, cliente.Email });
            }
        }

        private async Task<bool> Excluir(int id)
        {
            bool excluido = await _clienteService.RemoveAsync(id);
            if (excluido)
            {
                BuscaClientes();
                MessageBox.Show("Excluído com sucesso!");
                return true;
            }
            return false;
        }

        private void LimparCampos()
        {
            maskedTextBox_CPF.Text = String.Empty;
            textBox_Nome.Text = String.Empty;
            textBox_Email.Text = String.Empty;
        }

        private async void button_Consultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Consultar.Text))
            {
                BuscaClientes();
                return;
            }

            dataGridView_Clientes.Rows.Clear();

            string cpf = textBox_Consultar.Text;
            Cliente cliente = await _clienteService.FindByCPFAsync(cpf);

            if (cliente == null)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
                return;
            }

            dataGridView_Clientes.Rows.Add(new string[] { cliente.ID.ToString(), cliente.CPF, cliente.Nome, cliente.Email });
        }

        private bool VerificarAlteracao(int linha)
        {
            foreach (DataGridViewColumn item in dataGridView_Clientes.Columns)
            {
                var atual = dataGridView_Clientes.Rows[linha].Cells[item.Index].Value;
                var novo = dataGridView_Clientes.Rows[linha].Cells[item.Index].EditedFormattedValue;

                if (atual == null || novo == null)
                    return false;

                if (!atual.ToString().Equals(novo.ToString()))
                {
                    DialogResult result = MessageBox.Show($"Deseja alterar {atual} para {novo}", "Atualização de dados!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        private async Task Editar()
        {
            int linha = dataGridView_Clientes.CurrentRow.Index;

            bool linhaAtualizada = VerificarAlteracao(linha);

            Cliente cliente = new()
            {
                ID = int.Parse(dataGridView_Clientes.Rows[linha].Cells["Column_ID"].Value.ToString()),
                Nome = dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].EditedFormattedValue.ToString(),
                CPF = dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].EditedFormattedValue.ToString(),
                Email = dataGridView_Clientes.Rows[linha].Cells["Column_Email"].EditedFormattedValue.ToString()
            };

            if (!linhaAtualizada)
                return;

            bool atualizado = await _clienteService.UpdateAsync(cliente);

            if (atualizado)
            {
                MessageBox.Show("Cliente atualizado!");
            }
        }

        private async void dataGridView_Clientes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
