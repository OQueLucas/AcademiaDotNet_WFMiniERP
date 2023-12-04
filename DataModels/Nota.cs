using AcademiaDotNet_WFMiniERP.DataModels.Enum;

namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class Nota
    {
        public int ID { get; set; }
        public DateTime DataEmissao { get; set; }
        public virtual StatusNota Status { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemNota> itens { get; set; }

        public void AddItem(ItemNota itemNota)
        {
            itens.Add(itemNota);
        }
    }
}
