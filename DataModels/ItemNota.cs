﻿namespace AcademiaDotNet_WFMiniERP.DataModels
{
    public class ItemNota
    {
        public int ID { get; set; }
        public string Nome { get ; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public virtual Nota Nota { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
