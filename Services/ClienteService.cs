using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IList<Cliente>> FindAllAsync()
        {
            return await _contexto.Clientes.AsNoTrackingWithIdentityResolution().Include(cliente => cliente.Notas).ToListAsync();
        }

        public async Task<Cliente> FindByIDAsync(int id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }
        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            bool existe = await _contexto.Clientes.AnyAsync(x => x.ID == cliente.ID);
            if (!existe)
            {
                MessageBox.Show("Id not found!");
                return false;
            }

            try
            {
                _contexto.Update(cliente);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public async Task<Cliente> FindByCPFAsync(string cpf)
        {
            return await _contexto.Clientes.FirstOrDefaultAsync(cliente => cliente.CPF == cpf);
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
