using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.DataModels.Enum;
using AcademiaDotNet_WFMiniERP.Services;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormNotaFiscal : Form
    {
        private readonly ClienteService _clienteService = new();
        private readonly NotaService _notaServices = new();
        private Nota _nota;

        public FormNotaFiscal()
        {
            InitializeComponent();
            CenterToParent();
            BuscaNotas();
            FiltroClientes();
            FiltroStatus();
            NotaMensal();
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
            dataGridView_Notas.Rows.Clear();
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

            _nota = await _notaServices.FindByIDAsync(id);

            textBox_Cliente.Text = _nota.Cliente.Nome;
            maskedTextBox_CPF.Text = _nota.Cliente.CPF;
            maskedTextBox_DataEmissao.Text = _nota.DataEmissao.ToString("dd/MM/yyyy HH:mm");

            foreach (ItemNota item in _nota.itens)
            {
                dataGridView_ItensNota.Rows.Add(new string[] { item.ID.ToString(), item.Nome, item.Preco.ToString(), item.Quantidade.ToString(), item.ValorTotal.ToString() });
            }

            comboBox_Status.DataSource = Enum.GetNames(typeof(StatusNota));

            comboBox_Status.SelectedItem = _nota.Status.ToString();
        }

        private async void button_CancelarNota_Click(object sender, EventArgs e)
        {
            if (_nota == null)
            {
                MessageBox.Show("Nota não encontrada");
                return;
            }

            if (_nota.Status == StatusNota.Cancelada)
            {
                MessageBox.Show("Nota já foi cancelada!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Tem certeza que deseja excluir a nota?", "nota: " + _nota.ID, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                return;
            }

            _nota.Status = StatusNota.Cancelada;

            bool excluido = await _notaServices.UpdateAsync(_nota);

            if (excluido)
            {
                MessageBox.Show("Nota cancelada com sucesso!");
            }
        }

        private async void button_Filtrar_Click(object sender, EventArgs e)
        {
            int clienteID = 0;

            CBItem? clienteSelecionado = comboBox_FiltroCliente.SelectedItem as CBItem;

            if (clienteSelecionado != null)
            {
                clienteID = clienteSelecionado.ID;

                Cliente cliente = await _clienteService.FindByIDAsync(clienteID);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado!");
                    return;
                }
            }

            string statusID;

            CBItem? statusSelecionado = comboBox_FiltroStatus.SelectedItem as CBItem;

            if (statusSelecionado != null)
            {
                statusID = statusSelecionado.ID.ToString();
            }
            else
            {
                statusID = null;
            }

            DateTime dataInicio = dateTimePicker_FiltroInicioDataEmissao.Value;
            DateTime dataFinal = dateTimePicker_FiltroFinalDataEmissao.Value;

            dataGridView_Notas.Rows.Clear();

            var notas = await _notaServices.FindAllAsyncQuery(clienteID, statusID, dataInicio, dataFinal);

            if (notas.Count == 0)
            {
                MessageBox.Show("Não há notas nessas condições!");
                return;
            }

            foreach (Nota nota in notas)
            {
                dataGridView_Notas.Rows.Add(new string[] { nota.ID.ToString(), nota.DataEmissao.ToString(), nota.Status.ToString(), nota.Cliente.Nome });
            }
        }

        private void button_RemoverFiltros_Click(object sender, EventArgs e)
        {
            BuscaNotas();
            comboBox_FiltroCliente.SelectedIndex = 0;
            comboBox_FiltroStatus.SelectedIndex = 0;
        }

        public void NotaMensal()
        {
            DateTime hoje = DateTime.Today;
            DateTime inicio = new(hoje.Year, hoje.Month, 1);
            dateTimePicker_FiltroInicioDataEmissao.Value = inicio;
            dateTimePicker_FiltroFinalDataEmissao.Value = inicio.AddMonths(1).AddSeconds(-1);
        }

        private void button_ImprimirNota_Click(object sender, EventArgs e)
        {
            GerarPDF();
        }

        public void GerarPDF()
        {
            if (_nota == null)
            {
                MessageBox.Show("Selecione uma nota");
                return;
            }


            var arquivo = @"C:\dados\nota-fiscal-" + _nota.ID + "-ID" + DateTime.UtcNow.Ticks + ".pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("MiniERP"));
                document.Add(new Paragraph("Recibo: "));
                document.Add(new Paragraph($"CPF: {_nota.Cliente.CPF}"));
                document.Add(new Paragraph($"Status: {_nota.Status}"));
                document.Add(new Paragraph($"Nome: {_nota.Cliente.Nome}"));
                document.Add(new Paragraph($"Data de Emissão: {_nota.DataEmissao}"));
                document.Add(new Paragraph($"Extrato Nº. : {_nota.ID}"));

                float[] colunas = { 0.8F, 7, 1, 1, 2, 2 };

                Table table = new Table(UnitValue.CreatePercentArray(colunas)).UseAllAvailableWidth();

                table.AddCell("#");
                table.AddCell("Nome");
                table.AddCell("QTD");
                table.AddCell("UN");
                table.AddCell("Preço");
                table.AddCell("Valor Total");

                foreach (var item in _nota.itens)
                {
                    table.AddCell($"{item.ID}");
                    table.AddCell($"{item.Nome}");
                    table.AddCell($"{item.Quantidade}");
                    table.AddCell($"UN");
                    table.AddCell($"{item.Preco}");
                    table.AddCell($"{item.ValorTotal}");
                }

                document.Add(table);

                document.Close();
                pdfDocument.Close();
            }

            MessageBox.Show("Arquivo PDF gerado em " + arquivo);
        }
    }
}
