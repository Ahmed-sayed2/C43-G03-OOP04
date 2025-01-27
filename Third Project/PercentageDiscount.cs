using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Third_Project
{
    internal class PercentageDiscount:Discount
    {
        public decimal percentage { get; set; }
        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            DiscountProp = price * quantity * (percentage / 100);
            return DiscountProp;
        }
    }
}
