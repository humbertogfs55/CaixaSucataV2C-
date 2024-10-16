using System.ComponentModel;

namespace CaixaSucata.Models.ObjectModels
{
    public class Register
    {
        public Register()
        {
            PurchaseRegisterAmount = 0;
            SalesRegisterAmount = 0;
        }
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public decimal PurchaseRegisterAmount { get; set; }
        public decimal SalesRegisterAmount { get; set; }
    }
}
