namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
