namespace Estoque.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public void TotalPrice()
        {
            Price += CustomsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: R$ " + CustomsFee + ")";
        }
    }
}
