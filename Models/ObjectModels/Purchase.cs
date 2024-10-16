namespace CaixaSucata.Models.ObjectModels
{
    public class Purchase
    {
        public int Id { get; set; }
        public bool IsSale { get; set; }
        public Material Material { get; set; }
        public decimal Weight { get; set; }
        public decimal Value { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string SellerName { get; set; }
        public string DisplayBuyScreen
        {
            get { return Material.Name + "|Peso: " + Weight + "|Valor: " + Value; }
        }
        public string DisplayMainScreen
        {
            get { return PurchaseTime.ToString("HH:mm | ") + Material.Name + " | Valor: " + Value +"R$"+ " | Peso: " + Weight +"KG"; }
        }
    }
}
