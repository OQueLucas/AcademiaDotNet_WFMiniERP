using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademiaDotNet_WFMiniERP
{
    public partial class FormCliente : Form
    {
        private readonly Contexto contexto = new();

        public FormCliente()
        {
            InitializeComponent();
            CenterToParent();

            BuscaClientes();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new()
                {
                    CPF = maskedTextBox_CPF.Text,
                    Nome = textBox_Nome.Text,
                    Email = textBox_Email.Text
                };

                contexto.Add(cliente);
                contexto.SaveChanges();

                BuscaClientes();
                MessageBox.Show("Cliente inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        private void BuscaClientes()
        {
            var clientes = contexto.Clientes.ToList();
            dataGridView_Clientes.DataSource = clientes;
        }
        private bool Excluir(Cliente cliente)
        {
            DialogResult result = MessageBox.Show($"Deseja excluir: {cliente.Nome}", "Excluir registro", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return false;
            }
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
            BuscaClientes();
            MessageBox.Show("Excluído com sucesso!");
            return true;
        }
        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool excluirClick = e.ColumnIndex == dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_Excluir"].ColumnIndex;
            if (!excluirClick) return;
            Cliente cliente = new();
            int id = int.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());
            cliente = contexto.Clientes.Find(id);

            Excluir(cliente);
        }
    }
}
