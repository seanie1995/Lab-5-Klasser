using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Klasser
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel circle1 = new Cirkel(5);
            Cirkel circle2 = new Cirkel(6);

            Console.WriteLine($"Circle 1 has radius: {circle1.Radius}");
            Console.WriteLine($"Circle 2 has radius: {circle2.Radius}");
            Console.WriteLine("Press any key to print out circles' area.");
            Console.ReadKey();
            Console.WriteLine("Cirkel 1:");
            circle1.GetArea();
            Console.WriteLine("Cirkel 2:");
            circle2.GetArea();
            Console.WriteLine($"Press any key to print out a circle's circumference and volume");
            Console.ReadKey();
            Console.WriteLine("Cirkel 1:");
            circle1.GetCircumAndVolume();
            Console.WriteLine("Cirkel 2:");
            circle2.GetCircumAndVolume();
            Console.ReadKey();

            Triangle triangle1 = new Triangle(5, 8);

            Console.WriteLine($"Triangle has base {triangle1.Base} and height {triangle1.Height}");
            Console.WriteLine("Press any key to print out triangle's area");
            Console.ReadKey();
            triangle1.GetTriangeArea();
            Console.ReadKey();
        }
    }
}
