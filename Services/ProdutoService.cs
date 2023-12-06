using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;

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

        public async Task<List<ProdutoViewModel>> FindAllAsyncTeste()
        {
            //var query = (from Produto produtos in _contexto.Produtos.AsEnumerable() join fornecedor in _contexto.Fornecedores on produtos.FornecedorID equals fornecedor.ID select new { produtos.ID, produtos.Nome, produtos.Preco, fornecedor.RazaoSocial });
            var  query = await _contexto.Produtos
                .Join(_contexto.Fornecedores, produto => produto.FornecedorID, fornecedor => fornecedor.ID, (produto, fornecedor) => new { produto, fornecedor})
                .Select(x => new ProdutoViewModel
                {
                    ID = x.produto.ID,
                    Nome = x.produto.Nome,
                    Preco = x.produto.Preco,
                    RazaoSocial = x.fornecedor.RazaoSocial
                }).ToListAsync();

            return query;
        }

        public async Task<Produto> FindByIDAsync(int id)
        {
            return await _contexto.Produtos.FindAsync(id);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                Produto produto = await _contexto.Produtos.FindAsync(id);

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
