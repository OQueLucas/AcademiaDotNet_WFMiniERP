using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.Services;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormFornecedor : Form
    {
        private readonly FornecedorService _fornecedorService = new();

        public FormFornecedor()
        {
            InitializeComponent();
            CenterToParent();
            BuscaFornecedores();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void button_LimparCampos_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dataGridView_Fornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool excluirClick = e.ColumnIndex == dataGridView_Fornecedores.Rows[e.RowIndex].Cells["Column_Excluir"].ColumnIndex;

            if (!excluirClick) return;

            int id = int.Parse(dataGridView_Fornecedores.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
            Excluir(id);
        }

        private void maskedTextBox_CNPJ_Enter(object sender, EventArgs e)
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
                Fornecedor fornecedor = new()
                {
                    CNPJ = maskedTextBox_CNPJ.Text,
                    RazaoSocial = textBox_RazaoSocial.Text,
                };

                bool adicionado = await _fornecedorService.InsertAsync(fornecedor);
                if (adicionado)
                {
                    LimparCampos();
                    BuscaFornecedores();
                    MessageBox.Show("Fornecedor inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private async Task BuscaFornecedores()
        {
            var fornecedores = await _fornecedorService.FindAllAsync();
            dataGridView_Fornecedores.DataSource = fornecedores;
        }

        private async Task<bool> Excluir(int id)
        {
            bool excluido = await _fornecedorService.RemoveAsync(id);
            if (excluido)
            {
                BuscaFornecedores();
                MessageBox.Show("Excluído com sucesso!");
                return true;
            }
            return false;
        }

        private void LimparCampos()
        {
            maskedTextBox_CNPJ.Text = String.Empty;
            textBox_RazaoSocial.Text = String.Empty;
        }
    }
}
