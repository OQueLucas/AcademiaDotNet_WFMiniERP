using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.DataModels.Enum;
using AcademiaDotNet_WFMiniERP.Services;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormNotaFiscal : Form
    {
        private readonly ClienteService _clienteService = new();
        private readonly NotaService _notaServices = new();
        public FormNotaFiscal()
        {
            InitializeComponent();
            CenterToParent();
            BuscaNotas();
            FiltroClientes();
            FiltroStatus();
        }

        private async void FiltroClientes()
        {
            comboBox_FiltroCliente.Items.Clear();
            comboBox_FiltroCliente.Items.Insert(0, "Selecione um cliente: ");
            comboBox_FiltroCliente.SelectedIndex = 0;

            var clientes = await _clienteService.FindAllAsync();

            foreach (Cliente cliente in clientes)
            {
                CBItem item = new()
                {
                    ID = cliente.ID,
                    Name = $"({cliente.ID}) {cliente.Nome}"
                };
                comboBox_FiltroCliente.Items.Add(item);
            }
        }

        private async void FiltroStatus()
        {
            comboBox_FiltroStatus.Items.Clear();
            comboBox_FiltroStatus.Items.Insert(0, "Selecione um status: ");
            comboBox_FiltroStatus.SelectedIndex = 0;

            foreach (var status in Enum.GetValues(typeof(StatusNota)))
            {
                CBItem item = new()
                {
                    ID = (int)status,
                    Name = status.ToString(),
                };
                comboBox_FiltroStatus.Items.Add(item);
            }
        }

        private async Task BuscaNotas()
        {
            var notas = await _notaServices.FindAllAsync();
            dataGridView_Notas.AutoGenerateColumns = false;

            foreach (Nota nota in notas)
            {
                dataGridView_Notas.Rows.Add(new string[] { nota.ID.ToString(), nota.DataEmissao.ToString(), nota.Status.ToString(), nota.Cliente.Nome });
            }
        }

        private async void dataGridView_Notas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_ItensNota.Rows.Clear();
            if (dataGridView_Notas.CurrentRow == null)
            {
                return;
            }

            var linha = e.RowIndex;

            int id = int.Parse(dataGridView_Notas.Rows[linha].Cells["Column_ID"].Value.ToString());

            var nota = await _notaServices.FindByIDAsync(id);

            textBox_Cliente.Text = nota.Cliente.Nome;
            maskedTextBox_CPF.Text = nota.Cliente.CPF;
            maskedTextBox_DataEmissao.Text = nota.DataEmissao.ToString("dd/MM/yyyy HH:mm");

            foreach (ItemNota item in nota.itens)
            {
                dataGridView_ItensNota.Rows.Add(new string[] { item.ID.ToString(), item.Nome, item.Preco.ToString(), item.Quantidade.ToString(), item.ValorTotal.ToString() });
            }

            comboBox_Status.DataSource = Enum.GetNames(typeof(StatusNota));

            comboBox_Status.SelectedItem = nota.Status.ToString();
        }

        private async void button_CancelarNota_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_Notas.CurrentRow.Cells["Column_ID"].Value.ToString());
            var nota = await _notaServices.FindByIDAsync(id);

            if (nota == null)
            {
                MessageBox.Show("Nota não encontrada");
                return;
            }

            nota.Status = StatusNota.Cancelada;

            _notaServices.UpdateAsync(nota);
        }
    }
}
