using AcademiaDotNet_WFMiniERP.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AcademiaDotNet_WFMiniERP.Data
{
    internal class Contexto : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<ItemNota> ItemNota { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=miniERPEF; User ID=aulaentity; password=senha1234; language=Portuguese; Trusted_Connection=True; TrustServerCertificate=True;");

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nota>()
                .HasOne(nota => nota.Cliente)
                .WithMany(cliente => cliente.Notas)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Nota>()
                .HasMany(nota => nota.itens)
                .WithOne(item => item.Nota)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .HasOne(produto => produto.Fornecedor)
                .WithMany(fornecedor => fornecedor.Produtos)
                .HasForeignKey(produto => produto.FornecedorID)
                .HasPrincipalKey(fornecedor => fornecedor.ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemNota>()
                .HasOne(item => item.Produto);
        }
    }
}
