using ConsoleApp8.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Question_01
{
    internal class Circle : ICircle
    {
        public Circle(int a)
        {
            Area = a;
        }
        public int Area { get; set; }

        public void DisplayShapeInfo()
        => Console.WriteLine($"Area of Circle{Area}");
    }
}
