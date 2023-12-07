﻿using AcademiaDotNet_WFMiniERP.Data;
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

        public async Task<IList<Nota>> FindAllAsyncQuery()
        {
            var query = await _contexto.Notas
                .Join(_contexto.ItemNota, nota => nota.ID, item => item.ID, (nota, item) => new { nota, item })
                .Select(x => new Nota
                {

                }).ToListAsync();
            return query;
        }

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

        public async Task<IList<Nota>> FindAllAsync(DateOnly? data, StatusNota? status, int ClienteID)
        {
            var query = await _contexto.Notas
            .Where(nota =>
                (status == null ? true : nota.Status == status.Value) &&
                (data == null ? true : DateOnly.FromDateTime(nota.DataEmissao) == data) &&
                (ClienteID == 0 ? true : nota.ClienteID == ClienteID))
            .ToListAsync();
            return query;
        }
    }
}
