using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class FireDragon : Dragon
    {
        public FireDragon(string name, string element, int level) : base(name, element, level)
        {
        }

        public sealed override void DragonScream()
        {
            base.DragonScream();
            Console.WriteLine("Blasts you with Fire Style: Majestic Destroyer Flame");
        }
    }
}
