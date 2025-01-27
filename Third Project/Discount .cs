using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Third_Project
{
    internal abstract class Discount
    {
       public decimal DiscountProp { get; set; }
        
      public abstract decimal CalculateDiscount(decimal price, int quantity);


    }
}
