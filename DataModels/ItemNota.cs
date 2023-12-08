using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class ItemNota
    {
        public int ID { get; set; }
        public string Nome { get ; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get { return Preco * Quantidade; } set { value = Preco * Quantidade; } }
        public virtual Nota Nota { get; set; }
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
