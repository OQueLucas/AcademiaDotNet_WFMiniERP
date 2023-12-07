using AcademiaDotNet_WFMiniERP.Data;
using AcademiaDotNet_WFMiniERP.DataModels;
using AcademiaDotNet_WFMiniERP.DataModels.Enum;
using Microsoft.EntityFrameworkCore;

namespace AcademiaDotNet_WFMiniERP.Services
{
    internal class NotaService
    {
        private readonly Contexto _contexto = new();

        public async Task<bool> InsertAsync(Nota nota)
        {
            try
            {
                await _contexto.Notas.AddAsync(nota);
                await _contexto.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return false;
            }
        }

        public async Task<IList<Nota>> FindAllAsync()
        {
            return await _contexto.Notas.ToListAsync();
        }

        public async Task<IList<Nota>> FindAllAsyncQuery(int ClienteID, string? status, DateTime? dataInicio, DateTime? dataFinal)
        {
            var query = await _contexto.Notas
            .Where(nota =>
                (ClienteID == 0 ? true : nota.ClienteID == ClienteID) &&
                (status == null ? true : (int)nota.Status == int.Parse(status)) &&
                (dataInicio == null ? true : nota.DataEmissao >= dataInicio) &&
                (dataFinal == null ? true : nota.DataEmissao <= dataFinal)
                )
            .ToListAsync();
            return query;
        }

        //public async Task<IList<Nota>> FindAllAsyncQuery()
        //{
        //    var query = await _contexto.Notas
        //        .Join(_contexto.ItemNota, nota => nota.ID, item => item.ID, (nota, item) => new { nota, item })
        //        .Select(x => new Nota
        //        {

        //        }).ToListAsync();
        //    return query;
        //}

        public async Task<Nota> FindByIDAsync(int id)
        {
            return await _contexto.Notas.FindAsync(id);
        }

        public async Task UpdateAsync(Nota nota)
        {
            bool existe = await _contexto.Notas.AnyAsync(x => x.ID == nota.ID);
            if (!existe)
            {
                MessageBox.Show("Id not found!");
                return;
            }

            try
            {
                _contexto.Update(nota);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
