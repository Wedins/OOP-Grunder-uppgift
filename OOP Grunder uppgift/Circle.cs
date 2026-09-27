using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Grunder_uppgift
{
    internal class Circle
    {
        public double Radie { get; set; }
        
        public double GetArea()
        {
            double area;
            area =   Radie * Radie  * Math.PI;


            Console.WriteLine(area);
            return area;
        }

        public Circle (double radie)
        {
            Radie = radie;
            
        }
    }
}
