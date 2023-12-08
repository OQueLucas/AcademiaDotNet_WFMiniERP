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
            bool excluirClick = e.ColumnIndex == dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_Excluir"].ColumnIndex;

            if (!excluirClick) return;

            int id = int.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
            Excluir(id);
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
            var clientes = await _clienteService.FindAllAsync();
            dataGridView_Clientes.DataSource = clientes;
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
    }
}
