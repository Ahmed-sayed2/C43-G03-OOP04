using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Third_Project
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            DiscountProp = (price/ 2)*(quantity / 2);
            return DiscountProp;
        }
    }
}
