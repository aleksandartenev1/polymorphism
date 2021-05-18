using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class WaterDragon : Dragon
    {
        public WaterDragon(string name, string element, int level) : base(name, element, level)
        {
        }

        public sealed override void DragonScream()
        {
            base.DragonScream();
            Console.WriteLine("Blasts you with Water Style: Water Bomb");
        }
    }
}
