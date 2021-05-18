using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class EarthDragon : Dragon
    {
        public EarthDragon(string name, string element, int level) : base(name, element, level)
        {
        }

        public sealed override void DragonScream()
        {
            base.DragonScream();
            Console.WriteLine("Blasts you with Earth Style: Dust Storm");
        }
    }
}
