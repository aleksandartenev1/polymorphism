using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Polymorphism
{
    public class AirDragon : Dragon
    {
        public AirDragon(string name, string element, int level) : base(name, element, level)
        {
        }

        public sealed override void DragonScream()
        {
            base.DragonScream();
            Console.WriteLine("Blasts you with Wind Style: Vacuum Wave");
        }
    }
}
