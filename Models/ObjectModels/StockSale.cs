namespace CaixaSucata.Models.ObjectModels
{
    public class StockSale
    {
        public int Id { get; set; }
        public Material Material { get; set; }
        public decimal KilogramSalePrice { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal TotalValue { get; set; }
        public string FiscalNumber { get; set; }
        public string CompanyName{ get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public string TruckPlate { get; set; } 
        public DateTime SaleDate { get; set; }
    }
}
