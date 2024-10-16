using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSucata.Models.ObjectModels
{
    public class RegisterOperation
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPurchase { get; set; }
        public bool IsRemoval { get; set; }
    }
}
