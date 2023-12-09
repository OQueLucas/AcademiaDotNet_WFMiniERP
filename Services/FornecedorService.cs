using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AcademiaDotNet_WFMiniERP.Services
{
    internal class FornecedorService
    {
        private readonly Contexto _contexto = new();

        public async Task<bool> InsertAsync(Fornecedor fornecedor)
        {
            try
            {
                _contexto.AddAsync(fornecedor);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return false;
            }
        }

        public async Task<List<Fornecedor>> FindAllAsync()
        {
            return await _contexto.Fornecedores.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

        public async Task<Fornecedor> FindByIDAsync(int id)
        {
            return await _contexto.Fornecedores.FindAsync(id);
        }

        public async Task<Fornecedor> FindByCNPJAsync(string cnpj)
        {
            return await _contexto.Fornecedores.FirstOrDefaultAsync(fornecedor => fornecedor.CNPJ == cnpj);
        }

        public async Task<bool> UpdateAsync(Fornecedor fornecedor)
        {
            bool existe = await _contexto.Fornecedores.AnyAsync(x => x.ID == fornecedor.ID);
            if (!existe)
            {
                MessageBox.Show("Id not found!");
                return false;
            }

            try
            {
                _contexto.Update(fornecedor);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                Fornecedor fornecedor = await _contexto.Fornecedores.FindAsync(id);

                DialogResult result = MessageBox.Show($"Deseja excluir: {fornecedor.RazaoSocial}", "Excluir registro", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }

                _contexto.Fornecedores.Remove(fornecedor);
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
