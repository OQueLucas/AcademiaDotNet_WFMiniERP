namespace AcademiaDotNet_WFMiniERP.DataModels
{
    internal class CBItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
