namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class Cliente
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }
}
