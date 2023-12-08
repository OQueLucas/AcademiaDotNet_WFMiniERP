using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AcademiaDotNet_WFMiniERP.Services
{
    internal class ProdutoService
    {
        private readonly Contexto _contexto = new();

        public async Task<bool> InsertAsync(Produto produto)
        {
            try
            {
                await _contexto.Produtos.AddAsync(produto);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return false;
            }
        }

        public async Task<IList<Produto>> FindAllAsync()
        {
            return await _contexto.Produtos.ToListAsync();
        }

        public async Task<IList<Produto>> FindAllAsyncQuery()
        {
            var query = await _contexto.Produtos
                .Join(_contexto.Fornecedores, produto => produto.FornecedorID, fornecedor => fornecedor.ID, (produto, fornecedor) => new { produto, fornecedor })
                .Select(x => new Produto
                {
                    ID = x.produto.ID,
                    Nome = x.produto.Nome,
                    Preco = x.produto.Preco,
                    Fornecedor = x.fornecedor
                }).ToListAsync();
            return query;
        }

        public async Task<Produto> FindByIDAsync(int id)
        {
            return await _contexto.Produtos.FindAsync(id);
        }


        public async Task<bool> UpdateAsync(Produto produto)
        {
            bool existe = await _contexto.Produtos.AnyAsync(x => x.ID == produto.ID);
            if (!existe)
            {
                MessageBox.Show("Id not found!");
                return false;
            }

            try
            {
                _contexto.Update(produto);
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
                Produto produto = await _contexto.Produtos.FirstOrDefaultAsync(produto => produto.ID == id);

                DialogResult result = MessageBox.Show($"Deseja excluir: {produto.Nome}", "Excluir registro", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }

                _contexto.Produtos.Remove(produto);
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
