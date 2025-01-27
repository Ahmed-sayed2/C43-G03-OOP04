using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Third_Project
{
    internal abstract class User:Discount
    {
        public string Name { get; set; }
       public abstract Discount GetDiscount();
    }
}
