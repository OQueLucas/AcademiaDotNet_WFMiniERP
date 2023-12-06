namespace AcademiaDotNet_WFMiniERP.DataModels
{
    internal class CBItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
