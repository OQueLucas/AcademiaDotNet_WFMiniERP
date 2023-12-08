using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Preco { get; set; }
        public int FornecedorID { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
    }
}
