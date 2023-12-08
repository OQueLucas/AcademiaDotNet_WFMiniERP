using AcademiaDotNet_WFMiniERP.DataModels.Enum;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class Nota
    {
        public int ID { get; set; }
        public DateTime DataEmissao { get; set; }
        public virtual StatusNota Status { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemNota> itens { get; set; }

        public void GerarPDF()
        {
            if (this == null)
            {
                MessageBox.Show("Nota não encontrada!");
                return;
            }

            var arquivo = @"C:\dados\nota-fiscal-" + ID + "-ID" + DateTime.UtcNow.Ticks + ".pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("MiniERP"));
                document.Add(new Paragraph("Recibo: "));
                document.Add(new Paragraph($"CPF: {Cliente.CPF}"));
                document.Add(new Paragraph($"Status: {Status}"));
                document.Add(new Paragraph($"Nome: {Cliente.Nome}"));
                document.Add(new Paragraph($"Data de Emissão: {DataEmissao}"));
                document.Add(new Paragraph($"Extrato Nº. : {ID}"));

                float[] colunas = { 0.8F, 7, 1.5F, 1, 2, 2 };

                Table table = new Table(UnitValue.CreatePercentArray(colunas)).UseAllAvailableWidth();

                table.AddCell("#");
                table.AddCell("Nome");
                table.AddCell("QTD");
                table.AddCell("UN");
                table.AddCell("Preço");
                table.AddCell("Valor Total");

                foreach (var item in itens)
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
