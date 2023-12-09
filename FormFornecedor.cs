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
            if (e.ColumnIndex == dataGridView_Fornecedores.Columns["Column_Excluir"].Index && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView_Fornecedores.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
                Excluir(id);
            }
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
            dataGridView_Fornecedores.Rows.Clear();

            var fornecedores = await _fornecedorService.FindAllAsync();

            foreach (var fornecedor in fornecedores)
            {
                dataGridView_Fornecedores.Rows.Add(new string[] { fornecedor.ID.ToString(), fornecedor.CNPJ, fornecedor.RazaoSocial });
            }
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

        private async void button_Consultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Consultar.Text))
            {
                BuscaFornecedores();
                return;
            }

            dataGridView_Fornecedores.Rows.Clear();

            string cnpj = textBox_Consultar.Text;
            Fornecedor fornecedor = await _fornecedorService.FindByCNPJAsync(cnpj);

            if (fornecedor == null)
            {
                MessageBox.Show("Nenhum fornecedor encontrado!");
                return;
            }

            dataGridView_Fornecedores.Rows.Add(new string[] { fornecedor.ID.ToString(), fornecedor.CNPJ, fornecedor.RazaoSocial });
        }

        private bool VerificarAlteracao(int linha)
        {
            foreach (DataGridViewColumn item in dataGridView_Fornecedores.Columns)
            {
                var atual = dataGridView_Fornecedores.Rows[linha].Cells[item.Index].Value;
                var novo = dataGridView_Fornecedores.Rows[linha].Cells[item.Index].EditedFormattedValue;

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
            int linha = dataGridView_Fornecedores.CurrentRow.Index;

            bool linhaAtualizada = VerificarAlteracao(linha);

            if (!linhaAtualizada)
                return;

            Fornecedor fornecedor = new()
            {
                ID = int.Parse(dataGridView_Fornecedores.Rows[linha].Cells["Column_ID"].Value.ToString()),
                CNPJ = dataGridView_Fornecedores.Rows[linha].Cells["Column_CNPJ"].EditedFormattedValue.ToString(),
                RazaoSocial = dataGridView_Fornecedores.Rows[linha].Cells["Column_RazaoSocial"].EditedFormattedValue.ToString(),
            };

            bool atualizado = await _fornecedorService.UpdateAsync(fornecedor);

            if (atualizado)
            {
                MessageBox.Show("Fornecedor atualizado!");
            }
        }

        private void dataGridView_Fornecedores_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
