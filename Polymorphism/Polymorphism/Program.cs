using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var airDragon = new Heart();
            airDragon.Element = "air";

            Console.WriteLine(airDragon.Element);
        }
    }
}