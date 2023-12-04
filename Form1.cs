namespace AcademiaDotNet_WFMiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
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
    }
}
