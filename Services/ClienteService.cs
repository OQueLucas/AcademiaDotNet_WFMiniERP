using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace AcademiaDotNet_WFMiniERP.Services
{
    internal class ClienteService
    {
        private readonly Contexto _contexto = new();

        public async Task<bool> InsertAsync(Cliente cliente)
        {
            try
            {
                _contexto.AddAsync(cliente);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return false;
            }
        }

        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _contexto.Clientes.ToListAsync();
        }

        public async Task<Cliente> FindByIDAsync(int id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                Cliente cliente = await _contexto.Clientes.FindAsync(id);

                DialogResult result = MessageBox.Show($"Deseja excluir: {cliente.Nome}", "Excluir registro", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }

                _contexto.Clientes.Remove(cliente);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return false;
            }
        }
    }
}
