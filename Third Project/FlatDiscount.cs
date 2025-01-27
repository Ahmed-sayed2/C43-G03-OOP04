using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Third_Project
{
    internal class FlatDiscount : Discount
    {
        public decimal Amount { get; set; }
        
        public FlatDiscount(decimal a)
        {
            Amount = a;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            DiscountProp = Amount * (quantity>=1 ? quantity:1);
            return DiscountProp;
        }
    }
}
