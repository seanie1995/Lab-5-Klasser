using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Klasser
{
    internal class Cirkel
    {
        public double Radius { get; set; }
        
        public Cirkel(double Radius)
        {
            this.Radius = Radius;
        }
  
        public double GetRadius()
        {
            return Radius;
        }

        public void GetArea()
        {
            double area = Radius * Radius * 3.14;
            Console.WriteLine($"Circle's area is: {area}");
        }

        public void GetCircumAndVolume()
        {
            double circumference = (3.14 * 2) * Radius;
            double volume = (4/3) * (3.14 * (Radius * Radius * Radius));
            Console.WriteLine($"Sphere's circumference is {circumference} and volume is {volume}");
        }




    }
}
