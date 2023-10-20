using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Klasser
{
    internal class Triangle
    {
        public double Base {  get; set; }
        public double Height { get; set; }

        public Triangle(double baseTriangle, double height)
        {
            Base = baseTriangle;
            Height = height;
        }

        public void GetTriangeArea()
        {
            double triangleArea = (Base * Height) / 2;
            Console.WriteLine($"Triangle's area is {triangleArea}");
        }
    }
}
